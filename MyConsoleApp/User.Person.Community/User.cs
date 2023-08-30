namespace MyConsoleApp
{
    public class UserOld
    {
        public string Name { get; set; }
        public UserOld(string name) 
        {
            Name = name;
        }
        public void SendMessage(UserOld user, string message)
        { }
        public void Post(string message)
        { }
        public string GetInfo()
        { 
            return $"Имя={Name}";
        }
    }
}