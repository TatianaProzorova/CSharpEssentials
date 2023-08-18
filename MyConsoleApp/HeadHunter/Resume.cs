namespace MyConsoleApp
{
    public class Resume : Profile
    {
        private int WorkExperience { get; }
        public Resume(string ProfessionName, int workExperience) : base(ProfessionName)
        { 
            WorkExperience = workExperience;
        }

        protected override string GetInfo()
        {
            return $"Стаж работы: {WorkExperience}";
        }
    }
}



