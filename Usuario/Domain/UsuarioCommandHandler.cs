using CrudDapper.Usuario.Domain.Commands;
using CrudDapper.Usuario.Models;
using CrudDapper.Usuario.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CrudDapper.Usuario.Domain
{
    public class UsuarioCommandHandler : IRequestHandler<NovoUsuarioCommand, string>
    {
        private readonly IMediator _mediator;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioCommandHandler(IMediator mediator,
                                     IUsuarioRepository usuarioRepository)
        {
            _mediator = mediator;
            _usuarioRepository = usuarioRepository;
        }
        public Task<string> Handle(NovoUsuarioCommand request, CancellationToken cancellationToken)
        {
            if(request == null)
            {
                return Task.FromResult("Dados insuficientes");
            }

            var result = _usuarioRepository.Add(new UsuarioModel(request.Id,
                                                                 request.Name,
                                                                 request.Email,
                                                                 request.Senha,
                                                                 request.Nivel,
                                                                 request.StAtivo));
            if (!result)
            {
                return Task.FromResult("Não foi possível adicionar o usuário!");
            }

            return Task.FromResult("Usuário cadastrado com sucesso!");
        }
    }
}
