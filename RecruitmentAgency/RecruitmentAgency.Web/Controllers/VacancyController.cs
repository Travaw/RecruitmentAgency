using AutoMapper;
using RecruitmentAgency.Api.Services;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecruitmentAgency.Web.Controllers
{
    public class VacancyController : Controller
    {
        private readonly IVacancyAppService vacancyAppService;

        private readonly IEmployeeAppService employeeAppService;

        private readonly IMapper mapper;


        public VacancyController(IVacancyAppService vacancyAppService, IEmployeeAppService employeeAppService, IMapper mapper)
        {
            this.vacancyAppService = vacancyAppService;
            this.employeeAppService = employeeAppService;
            this.mapper = mapper;
        }
        // GET: Vacancy
        public ActionResult Index()
        {
            ICollection<VacancyDTO> vacancies;
            if (User.IsInRole("employee"))
            {
                vacancies = vacancyAppService.GetAllForUser(User.Identity.Name);
            }
            else
            {
                vacancies = vacancyAppService.GetAll();
            }
            var vacanciesModel = mapper.Map<ICollection<VacancyModel>>(vacancies);
            return View(vacanciesModel);
        }

        [HttpPost]
        public ActionResult Index(VacancySearchModel vacancySearchModel, string sortString)
        {
            var dto = mapper.Map<SearchVacancyDTO>(vacancySearchModel);
            ICollection<VacancyDTO> vacancies;
            switch (sortString)
            {
               case "-" : 
                    vacancies = vacancyAppService.Search(dto);
                    break;
                case "Должность":
                    vacancies = vacancyAppService.Search(dto).OrderBy(v=>v.Name).ToList();
                    break;
                case "Сфера деятельности":
                    vacancies = vacancyAppService.Search(dto).OrderBy(v => v.ProfessionalField).ToList();
                    break;
                case "Описание":
                    vacancies = vacancyAppService.Search(dto).OrderBy(v => v.Description).ToList();
                    break;
                case "Требования":
                    vacancies = vacancyAppService.Search(dto).OrderBy(v => v.Requierements).ToList();
                    break;
                case "З/п":
                    vacancies = vacancyAppService.Search(dto).OrderBy(v => v.SalaryFrom).ToList();
                    break;
                default: vacancies = vacancyAppService.Search(dto);
                    break;
            }
           
            return View(mapper.Map<ICollection<VacancyModel>>(vacancies));
        }

        [Authorize(Roles ="employee")]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "employee")]
        [HttpPost]
        public ActionResult Create(VacancyCreateModel vacancyCreateModel)
        {
            var dto = mapper.Map<CreateVacancyDTO>(vacancyCreateModel);
            //dto.UserId = userAppService.Get(User.Identity.Name).Id;
            dto.UserName = User.Identity.Name;
            vacancyAppService.Create(dto);
            return RedirectToAction("Index", "Vacancy");      
        }


        public ActionResult Details(int id)
        {
            var vacancy = vacancyAppService.Get(id);
            return  View(mapper.Map<VacancyModel>(vacancy));
        }

        public ActionResult SwitchActive(int id)
        {
            vacancyAppService.SwitchActive(id);
            return new JsonResult();
        }

        public ActionResult GetCandidates(int id)
        {
            var vacancy = vacancyAppService.Get(id);
            CandidateSearchModel candidateSModel = new CandidateSearchModel()
            {
                Experience = vacancy.Experience,
                ProfessionalField = vacancy.ProfessionalField,
                Skills = vacancy.Requierements
            };
            return RedirectToAction("Index", "Candidate", new { candidateSearchModel = candidateSModel });
        }
    }
}