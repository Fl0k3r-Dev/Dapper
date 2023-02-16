using CrudDapper.Usuario.Domain.Request;
using CrudDapper.Usuario.Domain.Response;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudDapper.Usuario.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<UsuarioResponse>> GetAll();
        Task<UsuarioResponse> GetById(Guid id);
        Task<bool> Add(UsuarioRequest request);
        Task<bool> Update(UsuarioRequest request, Guid id);
        Task<bool> Delete(Guid id);
    }
}
