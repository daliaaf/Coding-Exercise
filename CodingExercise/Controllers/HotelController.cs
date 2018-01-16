using System.Collections.Generic;
using System.Web.Mvc;
using CodingExercise.Models;
using CodingExercise.Mappings;
using CodingExercise.Models.SearchModels;
using CodingExercise.Models.BusinessModel;
using CodingExercise.Models.ViewModels;
using CodingExercise.Business.Logic;
using CodingExercise.Business.Interfaces;
using AutoMapper;
using CodingExercise.Models.Dtos;
namespace CodingExercise.Controllers
{
    public class HotelController : Controller
    {

        private IHotelLogic _hotelLogic;

        public HotelController(IHotelLogic hotelLogic )
        {
            _hotelLogic = hotelLogic;
        }


      /// <summary>
      /// Index the specified searchCriteria.
      /// </summary>
      /// <returns>The index.</returns>
        /// <param name="searchCriteria">Search criteria.- Should be "searchCriteria"</param>
        public ActionResult Index(SearchCriteriaDtos searchCriteria)
        {
            
            if (ModelState.IsValid)
            {
                // Map DTO model to view search model object
                var search = Mapper.Map<SearchCriteriaDtos, HotelSearch>(searchCriteria);
                // 
                var hotelApiList = _hotelLogic.GetHotelList(search, new SearchCriteria());


                var hotelList = new List<Hotel>();
                if (hotelApiList.Count > 0)
                {
                    // Map Api hotel model object to View hotel object
                    hotelList = Mapper.Map<List<ApiHotelInfo>, List<Hotel>>(hotelApiList);
                }

                var model = new SearchViewModel()
                {
                    Hotels = hotelList,
                    SearchCriteria = new HotelSearch()
                };
                return View(model);
            }

            // return null model
            return View(new SearchViewModel() { Hotels = new List<Hotel>(), SearchCriteria = new HotelSearch() });
        }


    }
}
