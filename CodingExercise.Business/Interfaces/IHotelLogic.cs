using System;
using System.Collections.Generic;
using CodingExercise.Models.SearchModels;

namespace CodingExercise.Business.Interfaces
{
    public interface IHotelLogic
    {
        List<CodingExercise.Models.BusinessModel.ApiHotelInfo> GetHotelList(HotelSearch searchCriteria,ISearchCriteria search);

    }
}
