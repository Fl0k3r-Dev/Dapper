using CrudDapper.Usuario.Domain.Request;
using CrudDapper.Usuario.Domain.Response;
using CrudDapper.Usuario.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUsuarioRepository _authRepository;
        public AuthController(IAuthRepository authRepository)       
        {
            _authRepository = authRepository;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<IEnumerable<UsuarioResponse>> Get()
        {
            return await _usuarioRepository.GetAll();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<UsuarioResponse> GetById([FromRoute] Guid id)
        {
            return await _usuarioRepository.GetById(id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UsuarioRequest usuario)
        {
            return Ok(await _usuarioRepository.Add(usuario));
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UsuarioRequest usuario)
        {
            return Ok(await _usuarioRepository.Update(usuario, id));
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await _usuarioRepository.Delete(id));
        }
    }
}
