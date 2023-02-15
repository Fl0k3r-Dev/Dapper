using System;

namespace Dapper.Usuario.Domain.Response
{
    public class UsuarioResponse
    {
        public Guid Id { get; set; }
        public string Nivel { get; set; }
        public DateTime DataUltimoAcesso { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
