using Gallery.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery.WebUI.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpGet]
        [Route("register")]
        public ActionResult Register()
        {
            return this.View("Register");
        }

        [HttpPost]
        [Route("register")]
        public ActionResult Register(RegistrationModel model)
        {
            return this.RedirectToRoute("RegisterSuccess");
        }

        [Route("register", Name = "RegisterSuccess")]
        public ActionResult RegisterSuccess()
        {
            return this.View("RegisterSuccess");
        }

        [HttpGet]
        [Route("login")]
        public ActionResult Login()
        {
            return this.View("Login");
        }

        [HttpPost]
        [Route("login")]
        public ActionResult Login(LoginModel model)
        {
            return this.RedirectToRoute("Index");
        }
    }
}