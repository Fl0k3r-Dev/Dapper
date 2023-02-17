using CrudDapper.Usuario.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudDapper.Usuario.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<UsuarioModel>> GetAll();
        Task<UsuarioModel> GetById(Guid id);
        bool Add(UsuarioModel request);
        bool Update(UsuarioModel request, Guid id);
        bool Delete(Guid id);
    }
}
