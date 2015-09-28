using Gallery.DAL.Repositories;
using Gallery.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery.WebUI.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            UserRepository repo = new UserRepository();
            IEnumerable<User> users = repo.GetAll();
            return View();
        }
    }
}