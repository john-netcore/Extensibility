using System;

namespace PersonRepository.Interface
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StartDate { get; set; }
        public int Rating { get; set; }
    }
}
