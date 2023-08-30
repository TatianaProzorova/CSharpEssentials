using System.Collections.Generic;

namespace MyConsoleApp
{
    public interface IUsersStorage
    {
        List<User> GetAll();
        User TryGetById(int id);
        void Add(User user);
    }
}
