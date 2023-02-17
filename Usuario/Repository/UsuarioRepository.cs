using CrudDapper.Usuario.Models;
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

        public Task<IEnumerable<UsuarioModel>> GetAll()
        {
            string sql = @"
                       SELECT id, nome, email, nivel, stAtivo FROM Usuario
                            ";
            using(var conn = new MySqlConnection(_connStr))
            {
                return conn.QueryFirstOrDefaultAsync<IEnumerable<UsuarioModel>>(sql);
            }
        }

        public Task<UsuarioModel> GetById(Guid id)
        {
            throw new System.NotImplementedException();
        }

        public bool Add(UsuarioModel usuario)
        {
            string sql = @"
                           INSERT INTO Usuario VALUES( @Id
                                                      ,@Name                                                  
                                                      ,@Email       
                                                      ,@Senha     
                                                      ,@Nivel   
                                                      ,@StAtivo)";

            using (var conn = new MySqlConnection(_connStr))
            {
                return conn.Execute(sql, usuario) > 0;
            }
        }

        public bool Update(UsuarioModel usuario, Guid id)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new System.NotImplementedException();
        }
    }
}
