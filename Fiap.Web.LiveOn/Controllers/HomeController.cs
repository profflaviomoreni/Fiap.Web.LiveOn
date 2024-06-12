using Fiap.Web.LiveOn.Data.Contexts;
using Fiap.Web.LiveOn.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fiap.Web.LiveOn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _context;


        public HomeController(ILogger<HomeController> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // SELECT * FROM Montadora
            //var lista = _context.Montadoras.ToList();


            //var montadora = new Montadora
            //{
            //    Nome = "Honda",
            //    AnoFundacao = 2002,
            //    PaisOrigem = "Japão"
            //};

            //_context.Montadoras.Add(montadora);
            //_context.SaveChanges();

            return View();
        }

        public IActionResult Privacy()
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
