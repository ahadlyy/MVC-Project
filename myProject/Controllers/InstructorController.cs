using Microsoft.AspNetCore.Mvc;
using myProject.Models;
using System.Linq;

namespace myProject.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            getDataFromModels instructorData = new getDataFromModels();
            List<Instructor> instructors = instructorData.GetAll();
            return View(instructors);
        }

        public IActionResult Details(int id)
        {
            getDataFromModels instructorData = new getDataFromModels();
            Instructor instructor = instructorData.GetInsById(id);
            return View(instructor);
        }
    }
}
