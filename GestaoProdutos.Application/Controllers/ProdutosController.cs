using GestaoProdutos.Dominio.Repositorio.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace GestaoProdutos.Application.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private IServicoProdutos serviceProdutos;
        public ProdutosController(IServicoProdutos service)
        {
            this.serviceProdutos = service;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid) 
            { 
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await serviceProdutos.GetAll());
            }
            catch (ArgumentException erro)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }
    }
}
