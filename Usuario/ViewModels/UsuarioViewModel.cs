using System;

namespace CrudDapper.Usuario.ViewModels
{
    public class UsuarioViewModel
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nivel { get; set; }
        public string StAtivo { get; set; }
    }
}
