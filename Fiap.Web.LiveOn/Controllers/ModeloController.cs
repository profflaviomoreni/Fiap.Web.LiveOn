using Fiap.Web.LiveOn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Web.LiveOn.Controllers
{
    public class ModeloController : Controller
    {

        private List<ModeloVeiculo> modeloVeiculos;

        private List<Montadora> montadoras;

        public ModeloController() {

            modeloVeiculos = new List<ModeloVeiculo>();
            modeloVeiculos.Add(new ModeloVeiculo(1, "Mustang",  2021, "Gasolina"));
            modeloVeiculos.Add(new ModeloVeiculo(2, "Corolla",  2022, "Híbrido"));
            modeloVeiculos.Add(new ModeloVeiculo(3, "Golf",  2020, "Diesel"));


            montadoras = new List<Montadora>
            {
                new Montadora(1,"Ford", "Estados Unidos", 1903),
                new Montadora(2,"Toyota", "Japão", 1937),
                new Montadora(3,"Volkswagen", "Alemanha", 1937)
            };


        }


        public IActionResult Index()
        {

            // SELECT * FROM TB_MODELOS
            //var listaModelos = repository.GetAll();
            var listaModelos = modeloVeiculos;

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
            var mensagem = "Veículos inserido com sucesso";
            return RedirectToAction("Index");   
        }



    }
}
