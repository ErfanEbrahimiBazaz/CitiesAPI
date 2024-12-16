using Cities.API.Models;
using System.Xml.Linq;

namespace Cities.API
{
    public class CitiesInMemory
    {
        public static IEnumerable<CityDto> CurrentCities
        {
            get
            {
                var Cities = new List<CityDto>()
                {
                    // object initializer works only when there is parameterless constructor.
                    new CityDto { Id = 1, Name = "Melbourne", Description = "Best city for expats.",
                        PointsOfInterests = new List<PointsOfInterestDto>
                        {
                            new PointsOfInterestDto { Id = 1, Name = "CBD", Description = "City Business District." },
                            new PointsOfInterestDto { Id = 2, Name = "Ocean Drive", Description = "Beautiful road near ocean." }
                        }
                    },
                    new CityDto { Id = 2, Name = "Sydney", Description = "Capital and bay city",
                    PointsOfInterests = new List<PointsOfInterestDto>
                        {
                            new PointsOfInterestDto{Id = 1, Name = "Bay"},
                            new PointsOfInterestDto{Id = 2, Name = "Bridge"}
                        }
                    },
                    new CityDto { Id = 3, Name = "Cairns", Description = "Land of alligator."}
                };
                return Cities;
            }
        }
    }
}
