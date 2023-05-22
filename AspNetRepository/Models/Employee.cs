using AspNetRepository.Repository;

namespace AspNetRepository.Models
{
    public class Employee : IEntity<int>
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public int salary { get; set; }
    }




    public class Student : IEntity<int>
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public int grade { get; set; }
    }
}
