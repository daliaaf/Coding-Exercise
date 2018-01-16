using System;
using CodingExercise.Models.SearchModels;
namespace CodingExercise.Business.Interfaces
{
    public interface ISearchCriteria
    {

        string GetSearchQuery(HotelSearch searchCriteria);
    }
}
