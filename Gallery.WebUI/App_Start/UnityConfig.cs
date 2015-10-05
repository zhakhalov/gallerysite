using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Gallery.DAL.Abstract.Repositories;
using Gallery.DAL.Repositories;

namespace Gallery.WebUI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IImageRepository, ImageRepository>();
            container.RegisterType<ITagRepository, TagRepository>();
            container.RegisterType<IUserRepository, UserRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}