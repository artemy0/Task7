using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Crew workers = new Crew
                (
                new Worker("Artem", "Gorbachev", 19, new Work(".NET Developer", "IBA", 0)),
                new Worker("Alex", "Yakushkin", 19, new Work("enginer", "Integral", 600))
                );

            //Add
            if(!workers.IsReadOnly)
            {
                workers.Add(new Worker("Evgen", "Gorbachev", 25, new Work("marketer", "Mango", 600)));
                workers.Insert(1, new Worker("Irea", "Shestakova", 21, new Work("HR", "Google", 800)));
            }


            //Print
            Console.WriteLine("Source array!!!");
            ShowInfo(workers);

            //workers.Workers is array encapsulated in the class to be sorted and new CrewComparer() is rule by which the array will be sorted.
            Array.Sort(workers.Workers, new CrewComparer());
            Console.Write("\n\n\n");

            Console.WriteLine("Sorted array!!!");
            ShowInfo(workers);

            Console.Write("\n\n\n");


            //Remove
            workers.RemoveAt(3);
            workers.Remove(new Worker("Alex", "Yakushkin", 19, new Work("enginer", "Integral", 600)));

            //Add array
            Worker worker1 = new Worker("Vlad", "Yzlov", 37, new Work("policeman", "KGB", 1000));
            Worker worker2 = new Worker("Gleb", "Stepanov", 21, new Work("JS developer", "IBA", 1000));
            workers.CopyTo(new Worker[] { worker1, worker2 }, 1);


            //Print result
            Console.WriteLine($"Resulting array with count = {workers.Count}!!!");
            ShowInfo(workers);


            workers.Clear();

            Console.ReadKey();
        }

        //Method for displaying information using foreach
        public static void ShowInfo(Crew workers)
        {
            foreach (Worker worker in workers)
            {
                worker.ShowWorkerInfo();
                Console.WriteLine();
            }
        }
    }
}
