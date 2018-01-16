using System;
using System.ComponentModel.DataAnnotations;
namespace CodingExercise.Models.ViewModels
{
    /// <summary>
    /// Hotel View Model.
    /// </summary>
    public class Hotel
    {
        [Display(Name = "Hotel Name")]
        public string HotelName { get; set; }
        public string DestinationCity { get; set; }
        public int RegionId { get; set; }
        public int LengthOfStay { get; set; }
        public decimal StarRating { get; set; }
        public decimal GuestRating { get; set; }
        public decimal price { get; set; }
  
    }
}
