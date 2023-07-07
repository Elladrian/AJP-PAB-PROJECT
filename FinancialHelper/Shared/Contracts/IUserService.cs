namespace FinancialHelper.Shared.Contracts
{
    public interface IUserService : IDisposable
    {
        Entities.User LogUser(string login, string password);
        Entities.User CreateUser(string login, string password);
        Entities.User DeleteUser(string login, string password);
        void Dispose();
        void Dispose(bool disposing);
    }
}
