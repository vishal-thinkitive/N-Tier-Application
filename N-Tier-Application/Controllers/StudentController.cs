using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using GE = GlobalEntity;

namespace N_Tier_Application.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentBC _studentBC;

        public StudentController(StudentBC _studentBC)
        {
            _studentBC = _studentBC;
        }

        // GET: Customers
        public IActionResult Index()
        {
            List<GE::Student> students = _studentBC.GetStudents();
            return View(students);
        }
    }
}
