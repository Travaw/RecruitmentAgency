using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using RecruitmentAgency.Api.Services;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Web.Strings;
using RecruitmentAgency.Web.Models;

namespace RecruitmentAgency.Web.Controllers
{
    /// <summary>
    /// Контроллер для работы с вакансиями
    /// </summary>
    public class VacancyController : Controller
    {               

        private readonly IVacancyAppService vacancyAppService;

        private readonly IEmployeeAppService employeeAppService;

        private readonly IMapper mapper;

        /// <summary>
        /// Инициализация экземпляра <see cref="VacancyController"/>
        /// </summary>
        /// <param name="vacancyAppService"></param>
        /// <param name="employeeAppService"></param>
        /// <param name="mapper"></param>
        
        public VacancyController(IVacancyAppService vacancyAppService, IEmployeeAppService employeeAppService, IMapper mapper)
        {
            this.vacancyAppService = vacancyAppService;
            this.employeeAppService = employeeAppService;
            this.mapper = mapper;
        }

        /// <summary>
        /// Получение списка вакансий
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public ActionResult Index()
        {
            ICollection<VacancyDTO> vacancies;
            if (User.IsInRole(RoleNames.Employee))
            {
                var userName = User.Identity.Name;
                var emp = employeeAppService.GetByUser(userName);
                if (emp == null)
                {
                    return RedirectToAction("Index", "Employee");
                }
                vacancies = vacancyAppService.GetAllForUser(userName);
            }
            else
            {
                vacancies = vacancyAppService.GetAll();
            }
            var vacanciesModel = mapper.Map<ICollection<VacancyModel>>(vacancies);
            return View(vacanciesModel);
        }

        /// <summary>
        /// Поиск по вакансиям
        /// </summary>
        /// <param name="vacancySearchModel">Параметры поиска</param>
        /// <param name="sortString">Параметр сортировка</param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public ActionResult Index(VacancySearchModel vacancySearchModel, string sortString)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("Search", vacancySearchModel);
            }
            var dto = mapper.Map<SearchVacancyDTO>(vacancySearchModel);
            ICollection<VacancyDTO> vacancies;
            switch (sortString)
            {
               case SortStrings.DontSort : 
                    vacancies = vacancyAppService.Search(dto);
                    break;
                case SortStrings.SortByVacancyName:
                    vacancies = vacancyAppService.Search(dto).OrderBy(v=>v.Name).ToList();
                    break;
                case SortStrings.SortByProfessionlField:
                    vacancies = vacancyAppService.Search(dto).OrderBy(v => v.ProfessionalField).ToList();
                    break;
                case SortStrings.SortByDescription:
                    vacancies = vacancyAppService.Search(dto).OrderBy(v => v.Description).ToList();
                    break;
                case SortStrings.SortByReqirements:
                    vacancies = vacancyAppService.Search(dto).OrderBy(v => v.Requierements).ToList();
                    break;
                case SortStrings.SortBySalary:
                    vacancies = vacancyAppService.Search(dto).OrderBy(v => v.SalaryFrom).ToList();
                    break;
                default: vacancies = vacancyAppService.Search(dto);
                    break;
            }
           
            return View(mapper.Map<ICollection<VacancyModel>>(vacancies));
        }

        /// <summary>
        /// Получение страницы создания вакансии
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = RoleNames.Employee)]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Сздание вакансии
        /// </summary>
        /// <param name="vacancyCreateModel">Данные новой вкансии</param>
        /// <returns></returns>
        [Authorize(Roles = RoleNames.Employee)]
        [HttpPost]
        public ActionResult Create(VacancyCreateModel vacancyCreateModel)
        {
            if (!ModelState.IsValid)
            {
                return View(vacancyCreateModel);
            }
            var dto = mapper.Map<CreateVacancyDTO>(vacancyCreateModel);
            //dto.UserId = userAppService.Get(User.Identity.Name).Id;
            dto.UserName = User.Identity.Name;
            vacancyAppService.Create(dto);
            return RedirectToAction("Index", "Vacancy");      
        }

        /// <summary>
        /// Получение сведений о вакансии
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            var vacancy = vacancyAppService.Get(id);
            return  View(mapper.Map<VacancyModel>(vacancy));
        }

        /// <summary>
        /// Установка статуса вакансии
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="status">Статус</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = RoleNames.Employee)]
        public ActionResult SetActive(int id, bool status)
        {            
            vacancyAppService.SetStatus(id, status);
            return new JsonResult();
        }

        /// <summary>
        /// Поиск подходящих канидатов
        /// </summary>
        /// <param name="id">Идентификатор вакансии</param>
        /// <returns></returns>
        [Authorize]
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