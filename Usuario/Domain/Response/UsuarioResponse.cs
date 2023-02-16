using System;

namespace CrudDapper.Usuario.Domain.Response
{
    public class UsuarioResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nivel { get; set; }
        public string StAtivo { get; set; }
    }
}
