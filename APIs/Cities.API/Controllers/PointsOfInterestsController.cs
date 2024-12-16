using Cities.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cities.API.Controllers
{

    [ApiController]
    [Route("api/cities/pointsofinterests")]
    public class PointsOfInterestsController : ControllerBase
    {
        private readonly IEnumerable<CityDto> _cities;
        public PointsOfInterestsController(IEnumerable<CityDto> cities)
        {
            cities = CitiesInMemory.CurrentCities;
            this._cities = cities;
        }

        //[HttpGet("cityId")]  https://localhost:7274/api/cities/pointsofinterests/cityId?cityId=2 -> obviously not a good url
        //[HttpGet] https://localhost:7274/api/cities/pointsofinterests?cityId=2 -> Without using parameter in HttpGet use query string
        [HttpGet("{cityId}")]
        public IActionResult PointsOfInterestsForCity(int cityId)
        {
            var city = this._cities.Where(c => c.Id == cityId).FirstOrDefault();
            if(city == null)
            {
                return NotFound();
            }
            var pointsOfInterests = city.PointsOfInterests;
            if(pointsOfInterests == null)
            {
                return NotFound();
            }
            return Ok(pointsOfInterests);
        }
    }
}
