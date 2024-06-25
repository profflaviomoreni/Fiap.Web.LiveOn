using Fiap.Web.LiveOn.Data.Contexts;
using Fiap.Web.LiveOn.Models;
using Fiap.Web.LiveOn.ViewModel;
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




            var vm = new DashboardViewModel();
            vm.TotalClientePF = 10;
            vm.TotalClientePJ = 99;
            vm.TotalClientes = 109;
            vm.TotalVendasMes = 1000;
            vm.TotalVeiculos = 56;


            return View(vm);
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
