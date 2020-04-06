using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;
using RecruitmentAgency.Api.Services;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Web.Models;


namespace RecruitmentAgency.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserAppService userService;

        private readonly IRoleAppService roleService;

        private readonly IMapper mapper;

        public AccountController(IUserAppService userService, IRoleAppService roleService, IMapper mapper)
        {
            this.userService = userService;
            this.roleService = roleService;
            this.mapper = mapper;
        }
        // GET: Account
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }

            return RedirectToRoute(new { controller = "Account", action = "Login" });
        }

        public ActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }
            var user = userService.Get(loginModel.Login, loginModel.Password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(loginModel.Login, true);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
            
        }

        [HttpGet]
        public ActionResult Registration()
        {
            var roles = roleService.GetAll();
            roles.Remove(roles.Where(role => role.Name == "admin").FirstOrDefault());
            var roleList = new SelectList(roles, "Id", "Name");
            ViewBag.Roles = roleList;
            return View();
        }

        [HttpPost]
        public ActionResult Registration(UserCreateModel registrationModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registrationModel);
            }
            var dto = mapper.Map<CreateUserDTO>(registrationModel);
            var user = userService.Get(registrationModel.Login);
            if (user != null)
            {
                return View(registrationModel);
            }
            userService.Create(dto);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
    }
}