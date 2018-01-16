using System;
using System.Collections.Generic;
using CodingExercise.Models.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace CodingExercise.Models.SearchModels
{
    /// <summary>
    /// Hotel search criteria Model.
    /// </summary>
    public class HotelSearch
    {
        public string destinationName { get; set; }
        public string destinationCity { get; set; }
        public string RegionIds { get; set; }
        public string minTripStartDate { get; set; }
        public string maxTripStartDate { get; set; }
        public int? LengthOfStay { get; set; }
        public decimal? MinStarRating { get; set; }
        public decimal? MaxStarRating { get; set; }
        public decimal? MinGuestRating { get; set; }
        public decimal? MaxGuestRating { get; set; }

    }
}
