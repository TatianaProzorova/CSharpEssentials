namespace MyConsoleApp
{
    public class Person : UserOld
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
        public void Subscribe(UserOld user)
        { }
    }
}