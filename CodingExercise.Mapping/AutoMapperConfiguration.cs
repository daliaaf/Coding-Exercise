using System;
using AutoMapper;
using CodingExercise.Models.BusinessModel;
using CodingExercise.Models.ViewModels;

namespace CodingExercise.Mappings
{
    public static class AutoMapperConfiguration
    {
        public static void InitializeAutoMapper()
        {


            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new MapperProfiles());
            });

        }
    }
}
