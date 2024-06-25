using Fiap.Web.LiveOn.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.LiveOn.Controllers
{
    public class MontadoraController : Controller
    {

        private readonly IMontadoraRepository _montadoraRepository;

        public MontadoraController(IMontadoraRepository montadoraRepository)
        {
            _montadoraRepository = montadoraRepository;
        }


        public IActionResult Index()
        {
            var lista = _montadoraRepository.FindAll();
            return View(lista);
        }

        public IActionResult Cadastrar()
        {
            var lista = _montadoraRepository.FindAll();
            return View(lista);
        }

    }
}
