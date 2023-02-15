using Dapper.Usuario.Domain.Request;
using Dapper.Usuario.Domain.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dapper.Usuario.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Task<IEnumerable<UsuarioResponse>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<UsuarioResponse> GetById()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Add(UsuarioRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(UsuarioRequest request, int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
