namespace DesignPattern.CQRS.PresentationLayer.CQRS.Results.PersonResult
{
    public class GetPersonHumanResourceQueryResult
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
