using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;

using RecruitmentAgency.Api.Services;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Web.Models;

namespace RecruitmentAgency.Web.Controllers
{
    /// <summary>
    /// Контроллер для работы с данными о пользователях
    /// </summary>
    public class UserController : Controller
    {
        private readonly IUserAppService userAppService;

        private readonly IMapper mapper;

        /// <summary>
        /// Инициация экземпляра <see cref="UserController"/>
        /// </summary>
        /// <param name="userAppService">Сервис для работы с пользователями</param>
        /// <param name="mapper">Маппер</param>
        public UserController(IUserAppService userAppService, IMapper mapper)
        {
            this.userAppService = userAppService;
            this.mapper = mapper;
        }

        /// <summary>
        /// Получить страницу со списком пользователей
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public ActionResult Index()
        {
            var users = userAppService.GetAll();
            return View(mapper.Map<ICollection<UserModel>>(users));
        }

        /// <summary>
        /// Получить страницу изменения профиля пользователя
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns></returns>
        [Authorize]
        public ActionResult Edit(int id)
        {
            return View();
        }

        /// <summary>
        /// Изменить профиль пользователя
        /// </summary>
        /// <param name="userEditModel">Данные для изменения</param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public ActionResult Edit(UserEditModel userEditModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userEditModel);
            }
            var user = mapper.Map<UpdateUserDTO>(userEditModel);
            userAppService.Update(user);
            return RedirectToAction("Index", "User");
        }
    }
}