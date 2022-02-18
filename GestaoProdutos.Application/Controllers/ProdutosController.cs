using GestaoProdutos.Dominio.Entity;
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
        public async Task<ActionResult> ListaRegistros()
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

        [HttpGet("{id}")]
        public async Task<ActionResult> RecuperarRegistroPorCodigo(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await serviceProdutos.Get(id));
            }
            catch (ArgumentException erro)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Inserir([FromBody] Produtos produtos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var resul = await serviceProdutos.Post(produtos);
                if (resul != null)
                {
                    return Ok(resul);
                    //return Created(new Uri(Url.Link("ObterDados", new { id = resul.Id })), resul);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException erro)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Editar([FromBody] Produtos produtos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var resul = await serviceProdutos.Put(produtos);
                if (resul != null)
                {
                    return Ok(resul);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException erro)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> RemoveProduto(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var resul = await serviceProdutos.Put(id);
                if (resul != null)
                {
                    return Ok(resul);
                    //return Created(new Uri(Url.Link("ObterDados", new { id = resul.Id })), resul);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException erro)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }
    }
}