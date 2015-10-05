using Gallery.DAL.Abstract.Repositories;
using Gallery.Entities.Entities;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Gallery.WebUI.Controllers
{
    public class HomeController : Controller
    {
        [Dependency]
        public IUserRepository UserRepository { private get; set; }

        [Route("")]
        public async Task<ActionResult> Index()
        {
            IEnumerable<User> users = await UserRepository.FindAllAsync();
            return View();
        }
    }
}