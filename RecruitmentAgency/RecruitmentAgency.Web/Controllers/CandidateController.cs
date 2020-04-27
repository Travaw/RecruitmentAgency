using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using RecruitmentAgency.Api.Services;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Web.Models;
using RecruitmentAgency.Web.Strings;

namespace RecruitmentAgency.Web.Controllers
{
    /// <summary>
    /// Контроллер для работы с кандиатами
    /// </summary>
    [Authorize]
    public class CandidateController : Controller
    {        
        private readonly ICandidateAppService candidateAppService;

        private readonly IUserAppService userAppService;

        private readonly IMapper mapper;

        /// <summary>
        /// Инициализация экземпляра <see cref="CandidateController"/>
        /// </summary>
        /// <param name="candidateAppService"></param>
        /// <param name="userAppService"></param>
        /// <param name="mapper"></param>
        public CandidateController (ICandidateAppService candidateAppService, IUserAppService userAppService, IMapper mapper)
        {
            this.candidateAppService = candidateAppService;
            this.userAppService = userAppService;
            this.mapper = mapper;
        }

        /// <summary>
        /// Получение списка кандидатов
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public ActionResult Index()
        {
            ICollection<CandidateDTO> candidates = candidateAppService.GetAll();           
            var candidateModel = mapper.Map<ICollection<CandidateModel>>(candidates);
            return View(candidateModel);
        }

        /// <summary>
        /// Поиск кандидатов
        /// </summary>
        /// <param name="candidateSearchModel">Параметры поиска</param>
        /// <param name="sortString">Параметр сортировка</param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public ActionResult Index( CandidateSearchModel candidateSearchModel, string sortString)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("Search", candidateSearchModel); 
            }
            var dto = mapper.Map<SearchCandidateDTO>(candidateSearchModel);
            ICollection<CandidateDTO> candidates;
            switch (sortString)
            {
                case SortStrings.DontSort:
                    candidates = candidateAppService.Search(dto);
                    break;
                case SortStrings.SortByExperience:
                    candidates = candidateAppService.Search(dto).OrderBy(v => v.Experience).ToList();
                    break;
                case SortStrings.SortByProfessionlField:
                    candidates = candidateAppService.Search(dto).OrderBy(v => v.ProfessionalField).ToList();
                    break;
                case SortStrings.SortBySkills:
                    candidates = candidateAppService.Search(dto).OrderBy(v => v.Skills).ToList();
                    break;
                
                default:
                    candidates = candidateAppService.Search(dto);
                    break;
            }

            return View(mapper.Map<ICollection<CandidateModel>>(candidates));
        }

        /// <summary>
        /// Получение страницы создания резюме
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Создние резюме
        /// </summary>
        /// <param name="candidateCreateModel">Данные для созания резюме</param>
        /// <returns></returns>
        [Authorize]
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

        /// <summary>
        /// Получение резюме пользователя
        /// </summary>
        /// <returns></returns>
        [Authorize]
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

        /// <summary>
        /// Получение 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public ActionResult Details(int id)
        {
            var candidate = candidateAppService.Get(id);
            var model = mapper.Map<CandidateModel>(candidate);
            return View(model);
        }

        /// <summary>
        /// Получение страницы редактирования резюме
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var candidate = candidateAppService.Get(id);
            var model = mapper.Map<CandidateEditModel>(candidate);
            return View(model);
        }

        /// <summary>
        /// Внесение изменений в резюме
        /// </summary>
        /// <param name="candidateEditModel">Данные для изменения резюме</param>
        /// <returns></returns>
        [Authorize]
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

        
    }
}