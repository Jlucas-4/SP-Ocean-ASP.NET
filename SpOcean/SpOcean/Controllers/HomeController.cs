using Microsoft.AspNetCore.Mvc;
using SpOcean.Models;
using System.Diagnostics;

namespace SpOcean.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Atividade()
        {
            return View();
        }
        public IActionResult Publicacao()
        {
            return View();
        }


        public IActionResult Snorkel()
        {
            return View();
        }
        public IActionResult Surf()
        {
            return View();
        }
        public IActionResult AsaDelta()
        {
            return View();
        }
        public IActionResult Passeios()
        {
            return View();
        }
        public IActionResult Rapel()
        {
            return View();
        }
        public IActionResult Eventos()
        {
            return View();
        }

        public IActionResult PraiaPrumirim()
        {
            return View();
        }
        public IActionResult PraiaCamburi()
        {
            return View();
        }
        public IActionResult PraiaIlha()
        {
            return View();
        }
        public IActionResult PraiaDeserto()
        {
            return View();
        }
        public IActionResult PraiaSonho() {
            return View();
        }
        public IActionResult PraiaGrande()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
