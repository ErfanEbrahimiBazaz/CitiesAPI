using Microsoft.AspNetCore.Mvc;

namespace Cities.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController: ControllerBase
    {

  
        //[HttpGet]
        //public ActionResult Cities() 
        //{
        //    var cities = new List<object>()
        //    {
        //        new { id=1, name = "Cairns"},
        //        new { id=2, name =  "Sydney"},
        //        new { id=3, name =  "Melbourne" }
        //    };
        //    return new JsonResult(cities);
        //}

        [HttpGet]
        public ActionResult Cities()
        {
            var cities = CitiesInMemory.CurrentCities;
            return Ok(cities);
        }

        [HttpGet("{cityId}")]
        public ActionResult City(int cityId)
        {
            var city = CitiesInMemory.CurrentCities.Where(c => c.Id == cityId);
            if(city == null || city.Count()==0)
            {
                return NotFound();
            }
            return Ok(city);
        }
    }
}
