namespace CrudDapper.Auth.Repository
{
    public interface IAuthRepository
    {
        bool IsAuthenticated(string id);
        bool GenerateToken(string id);
        bool Login(string email, string senha);
    }
}
