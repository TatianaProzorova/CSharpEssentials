using System;
using System.Collections.Generic;

namespace MyConsoleApp
{
    public class UsersInMemoryStorage : IUsersStorage
    {
        private List<User> _users = new List<User>();

        public List<User> GetAll()
        {
            return _users;
        }

        public User TryGetById(int id)
        {
            foreach (User user in _users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }

            return null;
        }

        public void Add(User user)
        {
            if (user == null) throw new ArgumentNullException("User does not exist");

            _users.Add(user);
        }

        // code from Main()
        // IUsersStorage usersStorage = new UsersInMemoryStorage();
        // List<User> users = usersStorage.GetAll();
        // Console.WriteLine(users.Count == 0); // True

        // User user = usersStorage.TryGetById(5);
        // Console.WriteLine(user == null); // True

        // usersStorage.Add(new User { Id = 1, Name = "Josef", Age = 26 });
        // usersStorage.Add(new User { Id = 2, Name = "Mark", Age = 27 });
        // Console.WriteLine(users.Count == 2); // True

        // user = usersStorage.TryGetById(2);
        // Console.WriteLine(user.Name == "Mark"); // True
    }
}
