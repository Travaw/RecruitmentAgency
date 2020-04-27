 using AutoMapper;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

using RecruitmentAgency.Api.Services;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Web.Models;
using RecruitmentAgency.Web.Strings;

namespace RecruitmentAgency.Web.Controllers
{
    /// <summary>
    /// Контроллер для работы с аккаунтом пользователя
    /// </summary>
    public class AccountController : Controller
    {
        private const string userExist = "Пользователь с таким логином уже существует";

        private const string incorrectLoginPassword = "Неверные логин и/или пароль";

        private readonly IUserAppService userService;

        private readonly IRoleAppService roleService;

        private readonly IMapper mapper;

        /// <summary>
        /// Инициализировать экземпляр <see cref="AccountController"/>
        /// </summary>
        /// <param name="userService">Сервис для работы с пользователями</param>
        /// <param name="roleService">Сервис для работы с ролями пользователей</param>
        /// <param name="mapper">Маппер</param>
        public AccountController(IUserAppService userService, IRoleAppService roleService, IMapper mapper)
        {
            this.userService = userService;
            this.roleService = roleService;
            this.mapper = mapper;
        }

        /// <summary>
        /// Получить страницу вода
        /// </summary>
        public ActionResult Login()
        {
            
            return View();
        }

        /// <summary>
        /// Выполнить вход
        /// </summary>
        /// <param name="model">Данные для входа</param>
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
                return RedirectToAction(ControllerStrings.IndexMethod, ControllerStrings.Home);
            }
            else
            {
                ModelState.AddModelError(string.Empty, incorrectLoginPassword);
                return View(loginModel);
            }
            
        }

        /// <summary>
        /// Получить страницу регистрации
        /// </summary>
        [HttpGet]
        public ActionResult Registration()
        {
            return View(new UserCreateModel { Roles = GetRolesList()});
        }

        /// <summary>
        /// Выполнить регистрацию
        /// </summary>
        /// <param name="registrationModel">Данные для регистрации</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Registration(UserCreateModel registrationModel)
        {
            if (!ModelState.IsValid)
            {
                registrationModel.Roles = GetRolesList();
                return View(registrationModel);
            }
            var dto = mapper.Map<CreateUserDTO>(registrationModel);
            var user = userService.Get(registrationModel.Login);
            if (user != null)
            {
                ModelState.AddModelError(string.Empty, userExist);
                registrationModel.Roles = GetRolesList();
                return View(registrationModel);
            }
            userService.Create(dto); 
            FormsAuthentication.SetAuthCookie(registrationModel.Login, true);
            return RedirectToAction(ControllerStrings.IndexMethod, ControllerStrings.Home);
        }

        /// <summary>
        /// Выйти из учётной записи
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction(ControllerStrings.LoginMethod, ControllerStrings.Account);
        }

        /// <summary>
        /// Получить список ролей
        /// </summary>
        /// <returns></returns>
        private SelectList GetRolesList()
        {
            var roles = roleService.GetAll();
            roles.Remove(roles.Where(role => role.Name == RoleNames.Admin).FirstOrDefault());
            var roleList = new SelectList(roles, "Id", "Name");
            return roleList;
        }
    }
}