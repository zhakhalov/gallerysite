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
        public ICategoryRepository CategoryRepository { private get; set; }

        [Route("", Name = "Index")]
        public async Task<ActionResult> Index()
        {
            IEnumerable<Category> categories = await CategoryRepository.FindAllAsync(0, 32);
            return View();
        }
    }
}