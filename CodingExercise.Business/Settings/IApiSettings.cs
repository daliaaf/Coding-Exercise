using System;
namespace CodingExercise.Business.Settings
{
    public interface IApiSettings
    {
         string ApiDomain { get; }
         string ApiUri { get; }
    }
}
