using AutoMapper;
using RecruitmentAgency.Api.Services;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Web.Models;
using System.Web.Mvc;

namespace RecruitmentAgency.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeAppService employeeAppService;

        private readonly IMapper mapper;
        public EmployeeController(IEmployeeAppService employeeAppService, IMapper mapper)
        {
            this.employeeAppService = employeeAppService;
            this.mapper = mapper;
        }
        // GET: Employee
        public ActionResult Index()
        {
            var candidate = employeeAppService.GetByUser(User.Identity.Name);
            if (candidate == null)
            {
                return View("Create");
            }
            var model = mapper.Map<EmployeeModel>(candidate);
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(EmployeeCreateModel employeeCreateModel)
        {
            if (!ModelState.IsValid)
            {
                return View(employeeCreateModel);
            }
            var dto = mapper.Map<CreateEmployeeDTO>(employeeCreateModel);
            dto.UserName = User.Identity.Name;
            //dto.UserId = userAppService.Get(User.Identity.Name).Id;            
            employeeAppService.Create(dto);
            return RedirectToAction("Index", "Employee");
        }


    }
}