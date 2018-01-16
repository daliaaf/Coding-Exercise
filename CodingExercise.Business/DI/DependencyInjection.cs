using System;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.Web;
using CodingExercise.Business.Interfaces;
using CodingExercise.Business.Logic;

namespace CodingExercise.Business.DI
{
    public class DependencyInjection
    {
        public DependencyInjection()
        {
        }
        public static void SetSimpleInjectorContainer()
        {

            var container = new Container();

            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            container.Register<IHotelLogic, HotelLogic>(Lifestyle.Scoped);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            DependencyResolver.SetResolver(
               new SimpleInjectorDependencyResolver(container));

        }
    }
}
