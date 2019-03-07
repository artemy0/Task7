using System;
using System.Collections.Generic;

namespace Task7
{
    //the class that will be used for sorting custom collections Crew when using the Array.Sort(workers.Workers, new CrewComparer()) method !!!
    class CrewComparer : IComparer<Worker>
    {
        public int Compare(Worker x, Worker y)
        {
            if (x.Work.Position.Length > y.Work.Position.Length)
                return 1;
            else if (x.Work.Position.Length < y.Work.Position.Length)
                return -1;
            else
                for (int i = 0; i < x.Work.Position.Length; i++)
                    if(x.Work.Position[i].CompareTo(y.Work.Position[i]) != 0)
                        return x.Work.Position[i].CompareTo(y.Work.Position[i]);
            return 0;
        }
    }
}
