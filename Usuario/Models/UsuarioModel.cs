using System;

namespace CrudDapper.Usuario.Models
{
    public class UsuarioModel
    {
        public UsuarioModel(Guid id, string? name, string? email, string? senha, string? nivel, string? stAtivo)
        {
            Id = id;
            Name = name;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            StAtivo = stAtivo;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Nivel { get; private set; }
        public string StAtivo { get; private set; }

    }


}
