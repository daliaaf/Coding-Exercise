using CodingExercise.Business.Interfaces;
using CodingExercise.Models.SearchModels;
using CodingExercise.Models.BusinessModel;
using CodingExercise.Business.Settings;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using CodingExercise.Models.ViewModels;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json.Linq;
using System.Web;


namespace CodingExercise.Business.Logic
{
    //ToDo 
    public class HotelLogic : IHotelLogic
    {

        /// <summary>
        /// Gets the hotel list.
        /// </summary>
        /// <returns>List of ApiHotelInfo - all hotel info.</returns>
        /// <param name="searchCriteria">Search criteria.</param>
        /// <param name="search">Search.</param>
        public List<ApiHotelInfo> GetHotelList(HotelSearch searchCriteria, ISearchCriteria search)
        {
            // Get Search query string from Search Criteria Object
            var queryString = search.GetSearchQuery(searchCriteria);

            //call expedia api passing search criteria query string
            var hotelApiList = makeRequest(queryString);

            return hotelApiList.ToList();
        }

        /// <summary>
        /// Call Expidia API.
        /// </summary>
        /// <returns>List of ApiHotelInfo - all hotel info.</returns>
        /// <param name="queryString">Query string - search Criteria.</param>
        public IEnumerable<ApiHotelInfo> makeRequest(string queryString)
        {
            var apiUri =HttpContext.Current.Server.UrlDecode(ApiSettings.Current.ApiUri);
            var apiDomain = ApiSettings.Current.ApiDomain ;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(apiDomain);

            // ToDo use UriBuilder
            if (queryString != string.Empty)
            {
                apiUri = apiUri + "&" + queryString;
            }

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(apiUri).Result;
            if (response.IsSuccessStatusCode)
            {
                JToken token = JObject.Parse(response.Content.ReadAsStringAsync().Result);
                var jValue = token.SelectToken("offers.Hotel");
                if (jValue != null)
                {
                    IEnumerable<ApiHotelInfo> list = (IEnumerable<ApiHotelInfo>)jValue.ToObject(typeof(IEnumerable<ApiHotelInfo>));
                    return list;
                }
            }

            return Enumerable.Empty<ApiHotelInfo>();
        }
    }
}
