using CrudDapper.Usuario.Domain.Request;
using CrudDapper.Usuario.Domain.Response;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudDapper.Usuario.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IConfiguration _config;
        private readonly string _connStr;
        public UsuarioRepository(IConfiguration configuration)
        {
            _config = configuration;
            _connStr = configuration.GetConnectionString("SqlConnection");
        }

        public Task<IEnumerable<UsuarioResponse>> GetAll()
        {
            string sql = @"
                       SELECT id, nome, email, nivel, stAtivo FROM Usuario
                            ";
            using(var conn = new MySqlConnection(_connStr))
            {
                return conn.QueryFirstOrDefaultAsync<IEnumerable<UsuarioResponse>>(sql);
            }
        }

        public Task<UsuarioResponse> GetById(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> Add(UsuarioRequest request)
        {
            string sql = @"
                           INSERT INTO Usuario VALUES(@Id
                                                      ,@Name                                                  
                                                      ,@Email       
                                                      ,@Senha     
                                                      ,@Nivel   
                                                      ,@StAtivo)";

            using (var conn = new MySqlConnection(_connStr))
            {
                request.GenerateId();
                return await conn.ExecuteAsync(sql, request) > 0;
            }
        }

        public Task<bool> Update(UsuarioRequest request, Guid id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new System.NotImplementedException();
        }
    }
}
