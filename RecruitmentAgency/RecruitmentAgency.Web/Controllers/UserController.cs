using AutoMapper;
using RecruitmentAgency.Api.Services;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace RecruitmentAgency.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserAppService userAppService;
        private readonly IMapper mapper;

        public UserController(IUserAppService userAppService, IMapper mapper)
        {
            this.userAppService = userAppService;
            this.mapper = mapper;
        }
        // GET: User
        public ActionResult Index()
        {
            var users = userAppService.GetAll();
            return View(mapper.Map<ICollection<UserModel>>(users));
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
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