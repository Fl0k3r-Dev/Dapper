using MediatR;
using System;

namespace CrudDapper.Usuario.Domain.Commands
{
    public class NovoUsuarioCommand : IRequest<string>
    {
        public NovoUsuarioCommand(string name, string email, string senha, string nivel, string stAtivo)
        {
            Id = Guid.NewGuid();
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
