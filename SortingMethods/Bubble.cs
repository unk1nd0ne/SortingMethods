using System;
using System.Collections.Generic;
using System.Text;

namespace SortingMethods
{
    class Bubble
    {
        public List<int> List { get; set; }
        public List<int> SortedList { get; }
        public Bubble (List<int> list)
        {
            List = list;
            SortedList = Sort(List);
        }
        public List<int> Sort (List<int> list)
        {
            bool sorted = false;

            while (!sorted)
            {
                int index = 0;
                bool action = false;
                while (index < list.Count - 1)
                {
                    int compA = list[index];
                    int compB = list[index + 1];
                    if (compA > compB)
                    {
                        list[index] = compB;
                        list[index + 1] = compA;
                        ++index;
                        action = true;

                    }
                    else
                    {
                        ++index;
                    }

                }
                Console.WriteLine($"[ {String.Join(", ", list)} ]");
                if (!action)
                {
                    sorted = true;
                }

            }
            return list;        }
    }
}
