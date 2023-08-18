namespace MyConsoleApp
{
    public class Vacancy : Profile
    {
        private int Compensation { get; }
        public Vacancy(string ProfessionName, int compensation) : base(ProfessionName)
        { 
            Compensation = compensation;
        }

        protected override string GetInfo()
        {
            return $"Предлагаемая зарплата: {Compensation}";  
        }
    }
}



