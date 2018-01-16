using System;
using System.Collections.Generic;
using AutoMapper;
using CodingExercise.Models.ViewModels;
using CodingExercise.Models.BusinessModel;
using CodingExercise.Models.SearchModels;
using CodingExercise.Models.Dtos;

namespace CodingExercise.Mappings
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<ApiHotelInfo, Hotel>()
                .ForMember(dst => dst.DestinationCity, src => src.MapFrom<string>(e => e.hotelInfo.hotelDestination))
                .ForMember(dst => dst.HotelName, src => src.MapFrom<string>(e => e.hotelInfo.hotelName))
                .ForMember(dst => dst.LengthOfStay, src => src.MapFrom<int>(e => e.offerDateRange.lengthOfStay))
                .ForMember(dst => dst.GuestRating, src => src.MapFrom<double>(e => e.hotelInfo.hotelGuestReviewRating))
                .ForMember(dst => dst.RegionId, src => src.MapFrom<string>(e => e.destination.regionID))
                .ForMember(dst => dst.price, src => src.MapFrom<double>(e => e.hotelPricingInfo.averagePriceValue))
                .ForMember(dst => dst.StarRating, src => src.MapFrom<string>(e => e.hotelInfo.hotelStarRating));
            CreateMap<SearchCriteriaDtos, HotelSearch>()
                .ForMember(dst => dst.minTripStartDate, src => src.MapFrom<string>(e => e.minTripStartDate==DateTime.MinValue?null
                                                                                   : e.minTripStartDate == null ?null:
                                                                                   (e.minTripStartDate.Value.ToString("yyyy-MM-dd"))))
                .ForMember(dst => dst.maxTripStartDate, src => src.MapFrom<string>(e => e.maxTripStartDate == DateTime.MinValue ? null
                                                                                   : e.maxTripStartDate == null?null
                                                                                   :(e.maxTripStartDate.Value.ToString("yyyy-MM-dd"))))
            ;
        }
    }
}
