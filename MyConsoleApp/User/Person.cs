namespace MyConsoleApp
{
    public class Person : User
    {
        public int Age { get; set; }
        public Person (string name, int age) : base(name)
        {
            Age = age;
        }
        public new string GetInfo()
        {
            return $"Имя={Name}, Возраст={Age}";
        }
        public void Subscribe(User user)
        { }
    }
}