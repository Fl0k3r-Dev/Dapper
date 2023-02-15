using System;

namespace Dapper.Usuario.Domain.Request
{
    public class UsuarioRequest
    {
        public string Username { get; set; }
        public string Senha { get; set; }
        public string Nivel { get; set; }
        public DateTime DataUltimoAcesso { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
