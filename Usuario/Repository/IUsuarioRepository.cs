using Dapper.Usuario.Domain.Request;
using Dapper.Usuario.Domain.Response;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dapper.Usuario.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<UsuarioResponse>> GetAll();
        Task<UsuarioResponse> GetById();
        Task<bool> Add(UsuarioRequest request);
        Task<bool> Update(UsuarioRequest request, int id);
        Task<bool> Delete(int id);
    }
}
