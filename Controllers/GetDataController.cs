using Day1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class GetDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getall() {


            var emp = SampleData.GetAll();
        return View("tast",emp);
        
        }

        public IActionResult getbyid(int id)
        {


            var employee = SampleData.GetByID(id);
            return View("Getemployee", employee);

        }


    }
}
