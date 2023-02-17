using CrudDapper.Usuario.Domain.Commands;
using CrudDapper.Usuario.Models;
using CrudDapper.Usuario.Repository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMediator _mediator;

        public UsuarioController(IUsuarioRepository usuarioRepository, IMediator mediator)
        {
            _usuarioRepository = usuarioRepository;
            _mediator = mediator;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<IEnumerable<UsuarioModel>> Get()
        {
            return await _usuarioRepository.GetAll();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<UsuarioModel> GetById([FromRoute] Guid id)
        {
            return await _usuarioRepository.GetById(id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public async Task<IActionResult> newUser([FromBody] NovoUsuarioCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<UsuarioController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(Guid id, [FromBody] UpdateUsuarioCommand usuario)
        //{
        //    return Ok(await _usuarioRepository.Update(usuario, id));
        //}

        // DELETE api/<UsuarioController>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(Guid id)
        //{
        //    return Ok(_usuarioRepository.Delete(id));
        //}
    }
}
