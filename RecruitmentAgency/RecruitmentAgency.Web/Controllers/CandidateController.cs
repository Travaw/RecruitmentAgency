using AutoMapper;
using RecruitmentAgency.Api.Services;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RecruitmentAgency.Web.Controllers
{
    [Authorize]
    public class CandidateController : Controller
    {
        private readonly ICandidateAppService candidateAppService;

        private readonly IUserAppService userAppService;

        private readonly IMapper mapper;

        public CandidateController (ICandidateAppService candidateAppService, IUserAppService userAppService, IMapper mapper)
        {
            this.candidateAppService = candidateAppService;
            this.userAppService = userAppService;
            this.mapper = mapper;
        }

        // GET: Candidate
        public ActionResult Index()
        {
            ICollection<CandidateDTO> candidates = candidateAppService.GetAll();           
            var candidateModel = mapper.Map<ICollection<CandidateModel>>(candidates);
            return View(candidateModel);
        }

        [HttpPost]
        public ActionResult Index( CandidateSearchModel candidateSearchModel, string sortString)
        {
            var dto = mapper.Map<SearchCandidateDTO>(candidateSearchModel);
            ICollection<CandidateDTO> candidates;
            switch (sortString)
            {
                case "-":
                    candidates = candidateAppService.Search(dto);
                    break;
                case "Опыт работы":
                    candidates = candidateAppService.Search(dto).OrderBy(v => v.Experience).ToList();
                    break;
                case "Сфера деятельности":
                    candidates = candidateAppService.Search(dto).OrderBy(v => v.ProfessionalField).ToList();
                    break;
                case "Навыки":
                    candidates = candidateAppService.Search(dto).OrderBy(v => v.Skills).ToList();
                    break;
                
                default:
                    candidates = candidateAppService.Search(dto);
                    break;
            }

            return View(mapper.Map<ICollection<CandidateModel>>(candidates));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CandidateCreateModel candidateCreateModel)
        {
            if (!ModelState.IsValid)
            {
                return View(candidateCreateModel);
            }
            var dto = mapper.Map<CreateCandidateDTO>(candidateCreateModel);
            //dto.UserId = userAppService.Get(User.Identity.Name).Id;
            int fileLength = candidateCreateModel.Photo.ContentLength;
            dto.Photo = new byte[fileLength];
            candidateCreateModel.Photo.InputStream.Read(dto.Photo, 0, fileLength);
            dto.UserName = User.Identity.Name;
            candidateAppService.Create(dto);            
            return RedirectToAction("Resume", "Candidate");
        }

        [HttpGet]
        public ActionResult Resume()
        {
            var candidate = candidateAppService.GetByUser(User.Identity.Name);
            if (candidate == null)
            {
                return View("Create");
            }
            var model = mapper.Map<CandidateModel>(candidate);
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var candidate = candidateAppService.Get(id);
            var model = mapper.Map<CandidateModel>(candidate);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var candidate = candidateAppService.Get(id);
            var model = mapper.Map<CandidateEditModel>(candidate);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CandidateEditModel candidateEditModel)
        {
            if (!ModelState.IsValid)
            {
                return View(candidateEditModel);
            }
            var dto = mapper.Map<UpdateCandidateDTO>(candidateEditModel);
            if (candidateEditModel.NewPhoto!= null)
            {
                int fileLength = candidateEditModel.NewPhoto.ContentLength;
                byte[] byteArr= new byte[fileLength];
                candidateEditModel.NewPhoto.InputStream.Read(byteArr, 0, fileLength);
                dto.Photo = Convert.ToBase64String(byteArr);
            }
            else
            {
                dto.Photo = candidateEditModel.OldPhoto;
            }
            //dto.UserId = userAppService.Get(User.Identity.Name).Id;
            var entity = candidateAppService.Update(dto);
            return View("Resume", mapper.Map<CandidateModel>(entity));
        }

        [HttpGet]
        public ActionResult Candidates(int id)
        {
            var candidates = candidateAppService.GetAll();
            var candidatesModel = mapper.Map<ICollection<CandidateModel>>(candidates);
            return View(candidatesModel);
        }
    }
}