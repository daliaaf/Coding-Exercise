using System.Reflection;
using System.Web;
using System.Web.Mvc;
using CodingExercise.Mappings;
using AutoMapper;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using CodingExercise.Business.DI;

namespace CodingExercise
{
    public class Bootstrapper
    {
        public static void Run()
        {
            DependencyInjection.SetSimpleInjectorContainer();
            //Configure AutoMapper
            AutoMapperConfiguration.InitializeAutoMapper();
        }

       
    }
}
