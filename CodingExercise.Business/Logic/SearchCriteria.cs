using CodingExercise.Business.Interfaces;
using CodingExercise.Models.SearchModels;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingExercise.Business.Logic
{
    public class SearchCriteria : ISearchCriteria
    {
        /// <summary>
        /// Gets the search query.
        /// </summary>
        /// <returns>The search query string.</returns>
        /// <param name="searchCriteria">Search criteria.</param>
        public string GetSearchQuery(HotelSearch searchCriteria)
        {

            if (searchCriteria != null)
            {
                // Get all properties on the object
                var properties = searchCriteria.GetType().GetProperties()
                  .Where(x => x.CanRead)
                  .Where(x => x.GetValue(searchCriteria, null) != null)
                  .ToDictionary(x => x.Name, x => x.GetValue(searchCriteria, null));

                // reurn query string
                return HttpContext.Current.Server.UrlDecode(string.Join("&", properties
         .Select(x => string.Concat(
             Uri.EscapeDataString(x.Key), "=",
                                 Uri.EscapeDataString(x.Value.ToString())))));

            }
            return string.Empty;

        }
    }
}