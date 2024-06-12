using Fiap.Web.LiveOn.Data.Contexts;
using Fiap.Web.LiveOn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Web.LiveOn.Controllers
{
    public class ModeloController : Controller
    {

        private List<ModeloVeiculo> modeloVeiculos;

        private List<Montadora> montadoras;


        private readonly DatabaseContext _databaseContext;


        public ModeloController(DatabaseContext databaseContext) {

            _databaseContext = databaseContext; // new DatabaseContext();

            montadoras = databaseContext.Montadoras.ToList();

        }


        public IActionResult Index()
        {

            // SELECT * FROM TB_MODELOS
            //var listaModelos = repository.GetAll();
            var listaModelos = _databaseContext.ModeloVeiculos.ToList();

            return View(listaModelos);
        }


        [HttpGet]
        public IActionResult Create()
        {
            var selectListMontadoras =
                new SelectList(montadoras,
                                nameof(Montadora.MontadoraId),
                                nameof(Montadora.Nome));

            ViewBag.Montadoras = selectListMontadoras;

            return View();
        }


        [HttpPost]
        public IActionResult Create(ModeloVeiculo modeloVeiculo)
        {
            // INSERT INTO TB_MODELO_VEICULOS

            _databaseContext.ModeloVeiculos.Add(modeloVeiculo);
            _databaseContext.SaveChanges();

            var mensagem = "Veículos inserido com sucesso";
            return RedirectToAction("Index");   
        }



    }
}
