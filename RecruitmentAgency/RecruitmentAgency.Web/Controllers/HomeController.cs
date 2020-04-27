using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecruitmentAgency.Web.Controllers
{
    /// <summary>
    /// Контроллер
    /// </summary>
    [Authorize]
    public class HomeController : Controller
    {
        /// <summary>
        /// Получить домашнюю страницу
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }

            return RedirectToRoute(new { controller = "Account", action = "Login" });
        }
        
    }
}