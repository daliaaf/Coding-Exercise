using System;
using System.Collections.Generic;
using CodingExercise.Models.SearchModels;
using CodingExercise.Models.ViewModels;
namespace CodingExercise.Models
{
    /// <summary>
    /// Search view model.
    /// </summary>
    public class SearchViewModel
    {
        public HotelSearch SearchCriteria { get; set; }
        public IEnumerable<Hotel> Hotels { get; set; }
   
    }
}
