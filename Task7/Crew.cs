using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task7
{
    class Crew : IList<Worker>
    {
        public Worker[] Workers { get; private set; }
        public int Count { get; private set; }

        public Crew(params Worker[] setWorkers)
        {
            Workers = setWorkers;
            if (setWorkers != null)
                Count = setWorkers.Length;
            else
                Count = 0;
        }

        public Worker this[int index]
        {
            get
            {
                return Workers[index];
            }
            set
            {
                Workers[index] = value;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false; //As it may change
            }
        }

        public void Add(Worker item)
        {
            Worker[] tempWorkers = new Worker[Count+1];

            for (int i = 0; i < Count; i++)
            {
                tempWorkers[i] = Workers[i];
            }
            tempWorkers[Count] = item;

            Workers = tempWorkers;
            Count++;
        }

        public void Clear()
        {
            Workers = null;
            Count = 0;
        }

        public bool Contains(Worker item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Workers[i].Equals(item))
                    return true;
            }
            return false;
        }

        public void CopyTo(Worker[] array, int arrayIndex)
        {
            Worker[] tempWorkers = new Worker[Count + array.Length];

            int i; //index to iterate over the tempWorker array

            //Adding the first half of the source array.
            for (i = 0; i < arrayIndex; i++)
                tempWorkers[i] = Workers[i];

            int iWorkers = i; //remember which element we stopped

            //Adding passed array
            for (int j = 0; j < array.Length; j++, i++)
                tempWorkers[i] = array[j];

            //Adding the second half of the source array.
            for ( ; iWorkers < Count; i++, iWorkers++)
                tempWorkers[i] = Workers[iWorkers];

            Workers = tempWorkers;
            Count += array.Length;
        }

        public int IndexOf(Worker item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Workers[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void Insert(int index, Worker item)
        {
            Worker[] tempWorkers = new Worker[Count + 1];

            for (int i = 0, j = 0; i < Count; j++)
            {
                if (index != j)
                {
                    tempWorkers[j] = Workers[i++];
                }
                else
                    tempWorkers[j] = item;
            }

            Workers = tempWorkers;
            Count += 1;
        }

        public bool Remove(Worker item)
        {
            Worker[] tempWorkers;

            if (Workers.Contains(item))
                tempWorkers = new Worker[Count - 1];
            else
                return false;

            for (int i = 0, j = 0; j < Count - 1; i++, j++)
            {
                if (Workers[i].Equals(item))
                    tempWorkers[j] = Workers[++i]; //skip item that we want to remove
                else
                    tempWorkers[j] = Workers[i];             
            }

            Workers = tempWorkers;
            Count -= 1;
            return true;
        }

        public void RemoveAt(int index)
        {
            Worker[] tempWorkers = new Worker[Count - 1];

            for (int i = 0, j = 0; j < Count - 1; i++, j++)
            {
                if (i == index)
                    tempWorkers[j] = Workers[++i];
                else
                    tempWorkers[j] = Workers[i];
            }

            Workers = tempWorkers;
            Count -= 1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        public IEnumerator<Worker> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return Workers[i];
            }
        }
    }
}
