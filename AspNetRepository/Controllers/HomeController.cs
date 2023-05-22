using AspNetRepository.Models;
using AspNetRepository.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AspNetRepository.Controllers
{
    public class HomeController : Controller
    {
        //UserManager<ApplicationUSer> usermanager;

        Repository<Employee, int> repEmployees;
        Repository<Student, int> repStudents;


        public HomeController(Repository<Employee, int> _repEmployees,
            Repository<Student, int> repStudents)
        {
            repEmployees = _repEmployees;
            this.repStudents = repStudents;
        }

        public IActionResult Index()
        {
            //usermanager.SignInAsync()

            return View(repEmployees.SearchEmployeesByName("r") );
        }

        public IActionResult Index2()
        {
            return View(repStudents.FindBestStudents());
        }
    }
}
