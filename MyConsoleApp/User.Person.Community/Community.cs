namespace MyConsoleApp
{
    public class Community : UserOld
    {
        string Description { get; set; }
        public Community(string name, string description) : base(name) 
        {
            Name = name;
            Description = description;
        }
        public new string GetInfo()
        {
            return $"Имя={Name}, Описание={Description}";
        }
    }
}