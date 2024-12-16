namespace Cities.API.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<PointsOfInterestDto>? PointsOfInterests { get; set; }

        // parameterless constructor
        public CityDto() {}
        public CityDto(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;   
            this.Description = description;
        }
    }
}
