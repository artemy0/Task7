using System;

namespace Task7
{
    class Worker
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public Work Work { get; set; }

        public Worker()
        {
        }

        public Worker(string fName, string lName, int age, Work work)
        {
            FName = fName;
            LName = lName;
            Age = age;
            Work = work;
        }

        public void ShowWorkerInfo()
        {
            Console.WriteLine($"First name: {FName}\nLast name: {LName}\nAge: {Age}");
            Work.ShowWorkInfo();
        }

        //Method for comparing two elements
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Worker tempWorker = (Worker)obj;
            if (this.FName == tempWorker.FName && this.LName == tempWorker.LName && this.Age == tempWorker.Age && this.Work.Position == tempWorker.Work.Position && this.Work.WorkPlace == tempWorker.Work.WorkPlace)
                return true;
            else
                return false;
        }
    }
}
