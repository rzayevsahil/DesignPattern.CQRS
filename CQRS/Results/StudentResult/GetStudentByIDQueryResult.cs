namespace DesignPattern.CQRS.PresentationLayer.CQRS.Results.StudentResult
{
    public class GetStudentByIDQueryResult
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
    }
}
