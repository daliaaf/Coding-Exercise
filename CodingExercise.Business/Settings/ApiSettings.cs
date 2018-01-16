using System;
using System.Web.Configuration;
using CodingExercise.Business.Settings;
using System.Reflection;


namespace CodingExercise.Business.Settings
{
    public class ApiSettings: IApiSettings
    {
        
        public ApiSettings()
        {
        }
        public string ApiDomain { get; private set; }
        public string ApiUri { get; private set; }


        private static volatile IApiSettings current;
        private static object lockObject = new object();

        public static IApiSettings Current
        {
            get
            {
                if (current == null)
                {
                    lock (lockObject)
                    {
                        if (current == null)
                        {
                            current = CreateNewSettings();
                        }
                    }
                }

                return current;
            }
        }

        private static IApiSettings CreateNewSettings()
        {
            ApiSettings settings = new ApiSettings();

            settings.ApiDomain = WebConfigurationManager.AppSettings["ApiDomain"];
            settings.ApiUri = WebConfigurationManager.AppSettings["ApiUri"];

            return settings;
        }

    }
}
