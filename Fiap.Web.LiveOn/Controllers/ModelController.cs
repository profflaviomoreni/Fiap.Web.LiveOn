using Fiap.Web.LiveOn.Data.Contexts;
using Fiap.Web.LiveOn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.LiveOn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {

        private readonly DatabaseContext _databaseContext;

        public ModelController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;    

        }


        [HttpGet]
        public ActionResult<List<ModeloVeiculo>> Get()
        {
            var lista = _databaseContext.ModeloVeiculos.ToList();
            return Ok(lista);
        }


        [HttpGet("{id}")]
        public ActionResult<ModeloVeiculo> Get([FromRoute] int id)
        {

            var m = _databaseContext.ModeloVeiculos.Find(id);

            if ( m  == null )
            {
                return NotFound();
            }

            return Ok(m);
        }

        [HttpPost]
        public ActionResult Post([FromBody] ModeloVeiculo modeloVeiculo)
        {
            _databaseContext.ModeloVeiculos.Add(modeloVeiculo);
            _databaseContext.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = modeloVeiculo.ModeloVeiculoId } , modeloVeiculo ); 
        }



        [HttpPut("{id}")]
        public ActionResult Put([FromRoute] int id, [FromBody] ModeloVeiculo modeloVeiculo)
        {
            _databaseContext.ModeloVeiculos.Update(modeloVeiculo);
            _databaseContext.SaveChanges();

            return NoContent();
        }

    }
}
