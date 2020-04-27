using AutoMapper;
using System.Web.Mvc;

using RecruitmentAgency.Api.Services;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Web.Models;

namespace RecruitmentAgency.Web.Controllers
{
    /// <summary>
    /// Контроллер для работы с работодателями
    /// </summary>
    public class EmployeeController : Controller
    {
        private readonly IEmployeeAppService employeeAppService;

        private readonly IMapper mapper;

        /// <summary>
        /// Инициализация экземпляра <see cref="EmployeeController"/>
        /// </summary>
        /// <param name="employeeAppService"></param>
        /// <param name="mapper"></param>
        public EmployeeController(IEmployeeAppService employeeAppService, IMapper mapper)
        {
            this.employeeAppService = employeeAppService;
            this.mapper = mapper;
        }

        /// <summary>
        /// Получение сведений о компании пользователя
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public ActionResult Index()
        {
            var employee = employeeAppService.GetByUser(User.Identity.Name);
            if (employee == null)
            {
                return View(ViewStrings.CreateView);
            }
            var model = mapper.Map<EmployeeModel>(employee);
            return View(model);
        }

        /// <summary>
        /// Создание компании
        /// </summary>
        /// <param name="employeeCreateModel">Данные компании</param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public ActionResult Create(EmployeeCreateModel employeeCreateModel)
        {
            if (!ModelState.IsValid)
            {
                return View(employeeCreateModel);
            }
            var dto = mapper.Map<CreateEmployeeDTO>(employeeCreateModel);
            dto.UserName = User.Identity.Name;         
            employeeAppService.Create(dto);
            return RedirectToAction(ControllerStrings.IndexMethod, ControllerStrings.Employee);
        }


    }
}