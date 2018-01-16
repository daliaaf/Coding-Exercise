using System;
using System;
using System.Collections.Generic;
using CodingExercise.Models.ViewModels;
using System.ComponentModel.DataAnnotations;
namespace CodingExercise.Models.Dtos
{
    public class SearchCriteriaDtos
    {
        public string destinationName { get; set; }
        public string destinationCity { get; set; }
        [RegularExpression("([0-9]+(,[0-9]+)*)", ErrorMessage = "Numbers must be comma separated ")]
        public string RegionIds { get; set; }
       
        public DateTime? minTripStartDate { get; set; }
        public DateTime? maxTripStartDate { get; set; }
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Count must be a natural number")]
        public int? LengthOfStay { get; set; }
        [Range(1, 5)]
        public decimal? MinStarRating { get; set; }
        [Range(1, 5)]
        public decimal? MaxStarRating { get; set; }
        [Range(1, 5)]
        public decimal? MinGuestRating { get; set; }
        [Range(1, 5)]
        public decimal? MaxGuestRating { get; set; }
    }
}
