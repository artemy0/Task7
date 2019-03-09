using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Crew crew = new Crew
                (
                new Worker("Artem", "Gorbachev", 19, new Work(".NET Developer", "IBA", 0)),
                new Worker("Alex", "Yakushkin", 19, new Work("enginer", "Integral", 600))
                );

            //Add
            if(!crew.IsReadOnly)
            {
                crew.Add(new Worker("Evgen", "Gorbachev", 25, new Work("marketer", "Mango", 600)));
                crew.Insert(1, new Worker("Irea", "Shestakova", 21, new Work("HR", "Google", 800)));
            }


            //Print
            Console.WriteLine("Source array!!!");
            ShowInfo(crew);

            //workers.Workers is array encapsulated in the class to be sorted and new CrewComparer() is rule by which the array will be sorted.
            Array.Sort(crew.Workers, new CrewComparer());
            Console.Write("\n\n\n");

            Console.WriteLine("Sorted array!!!");
            ShowInfo(crew);

            Console.Write("\n\n\n");


            //Remove
            crew.RemoveAt(3);
            crew.Remove(new Worker("Alex", "Yakushkin", 19, new Work("enginer", "Integral", 600)));

            //Add array
            Worker worker1 = new Worker("Vlad", "Yzlov", 37, new Work("policeman", "KGB", 1000));
            Worker worker2 = new Worker("Gleb", "Stepanov", 21, new Work("JS developer", "IBA", 1000));
            crew.CopyTo(new Worker[] { worker1, worker2 }, 1);


            //Print result
            Console.WriteLine($"Resulting array with count = {crew.Count}!!!");
            ShowInfo(crew);


            crew.Clear();

            Console.ReadKey();
        }

        //Method for displaying information using foreach
        public static void ShowInfo(Crew crew)
        {
            foreach (Worker worker in crew)
            {
                worker.ShowWorkerInfo();
                Console.WriteLine();
            }
        }
    }
}
