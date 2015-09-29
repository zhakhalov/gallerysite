using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Diagnostics;

[assembly: OwinStartup(typeof(Gallery.WebUI.Startup))]

namespace Gallery.WebUI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Debug.WriteLine("Startup");
        }
    }
}
