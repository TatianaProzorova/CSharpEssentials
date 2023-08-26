using System.Collections.Generic;
using System;
using static MyConsoleApp.Program;
using System.Configuration;

namespace MyConsoleApp
{
    class Program
    {
        public interface IStudent
        {
            string Name { get; set; }
            void ListeningLection();

            void DoHomework(string excersize);

            void PrepareToExam();
        }

        static void Main()
        {

        }
    }
}
