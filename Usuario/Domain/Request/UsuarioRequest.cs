using System;

namespace CrudDapper.Usuario.Domain.Request
{
    public class UsuarioRequest
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nivel { get; set; }
        public string StAtivo { get; set; }

        public void GenerateId()
        {
            Id = Guid.NewGuid();
        }
    }
}
