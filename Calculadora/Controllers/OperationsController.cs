using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    public class OperationsController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Add");
        }
        public IActionResult Add(double a, double b)
        {
            ViewData["Result"] = a + b;
            return View();
        }

        public IActionResult Subtract(double a, double b)
        {
            ViewData["Result"] = a - b;
            return View();
        }

        public IActionResult Multiply(double a, double b)
        {
            ViewData["Result"] = a * b;
            return View();
        }

        public IActionResult Divide(double a, double b)
        {
            if (b == 0)
            {
                ViewData["Result"] = "Error: División por cero no permitida.";
            }
            else
            {
                ViewData["Result"] = a / b;
            }
            return View();
        }
    }

}
