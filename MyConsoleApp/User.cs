namespace MyConsoleApp
{
    public class User
    {
        public string Name { get; set; }
        public User(string name) 
        {
            Name = name;
        }
        public void SendMessage(User user, string message)
        { }
        public void Post(string message)
        { }
        public string GetInfo()
        { 
            return $"Имя={Name}";
        }
    }
}