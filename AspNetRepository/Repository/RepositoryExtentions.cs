using AspNetRepository.Models;
using System.Runtime.CompilerServices;

namespace AspNetRepository.Repository
{
    public static class RepositoryExtentions
    {
        public static List<Employee> SearchEmployeesByName(this Repository<Employee,int> repEmployees  , string name)
        {
            return repEmployees.db.Employees.Where(x => x.name.Contains(name)).ToList();
        }


        public static Student FindBestStudents(this Repository<Student, int> repStudents)
        {
            return repStudents.db.Students.First();
;        }

    }
}
