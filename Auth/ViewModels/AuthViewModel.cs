using System;

namespace CrudDapper.Auth.ViewModels
{
    public class AuthViewModel
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Nivel { get; private set; }
        public string StAtivo { get; private set; }
    }
}
