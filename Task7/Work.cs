using System;

namespace Task7
{
    class Work
    {
        public string Position { get; set; }
        public string WorkPlace { get; set; }
        public double Wage { get; set; }

        public Work()
        {
        }
        public Work(string position, string workPlace, double wage)
        {
            Position = position;
            WorkPlace = workPlace;
            Wage = wage;
        }

        public void ShowWorkInfo()
        {
            Console.WriteLine($"Position: {Position} - Work place {WorkPlace} and wage {Wage:C2}");
        }
    }
}
