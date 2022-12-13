using System;

namespace DesignPattern.CQRS.PresentationLayer.DAL.Entity
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Department { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public string WorkArea { get; set; }
        public string Image { get; set; }
        public DateTime StartWork { get; set; }
        public bool Status { get; set; }
    }
}
