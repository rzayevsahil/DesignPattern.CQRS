namespace DesignPattern.CQRS.PresentationLayer.CQRS.Results.UniversityResult
{
    public class GetUniversityUpdateByIDQueryResult
    {
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
    }
}
