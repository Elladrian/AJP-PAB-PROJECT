using FinancialHelper.Entities;
using FinancialHelper.Shared.Contracts;
using static BCrypt.Net.BCrypt;

namespace FinancialHelper.Shared.Services
{
    public class UserService : IUserService
    {
        public User DeleteUser(string login, string password)
        {
            using (DatabaseContext databaseContext = new())
            {
                User deletedUser = databaseContext.Users
                    .Where(u => (u.Login == login))
                    .FirstOrDefault();

                var pass = Verify(password, deletedUser.Password);

                if (deletedUser == null || !pass) return null;

                databaseContext.Users.Remove(deletedUser);
                databaseContext.SaveChanges();

                return deletedUser;
            }
        }

        public User CreateUser(string login, string password)
        {
            int salt = 666;
            using (DatabaseContext databaseContext = new())
            {
                User checkedUser = databaseContext.Users
                    .Where(u => (u.Login == login))
                    .FirstOrDefault();

                if (checkedUser != null) return null;

                User newUser = new()
                {
                    Login = login,
                    Password = HashPassword(password, salt),
                };

                databaseContext.Users.Add(newUser);
                databaseContext.SaveChanges();

                return newUser;
            }
        }

        public User LogUser(string login, string password)
        {
            using (DatabaseContext databaseContext = new())
            {
                User loggedUser = databaseContext.Users
                    .Where(u => u.Login == login)
                    .FirstOrDefault();

                if (loggedUser == null) return null;
                var pass = Verify(password, loggedUser.Password);

                if(pass)return loggedUser;

                return null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (disposing) { }
        }
    }
}
