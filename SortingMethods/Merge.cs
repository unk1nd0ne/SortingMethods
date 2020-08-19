using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingMethods
{
    class Merge
    {
        public List<int> List { get; set; }
        public List<int> SortedList { get; }
        public Merge(List<int> list)
        {
            List = list;
            SortedList = Sort(List);
        }
        public List<int> Sort(List<int> list)
        {
            List<int> a;
            List<int> b;
            List<int> left;
            List<int> right;

            if (list.Count == 1)
            {
                return list; ;
            }
            else
            {
                int midNum = (list.Count / 2);
                a = list.GetRange(0, list.Count - midNum);
                b = list.GetRange(midNum, list.Count - midNum);
                Console.WriteLine($"a [ {String.Join(", ", a)} ]");
                Console.WriteLine($"b [ {String.Join(", ", b)} ]");
                left = Sort(a);
                right = Sort(b);

                return merge(left, right);
            }
        }

        public List<int> merge(List<int> a, List<int> b)
        {
            Console.WriteLine($"a [ {String.Join(", ", a)} ]");
            Console.WriteLine($"b [ {String.Join(", ", b)} ]");
            List<int> merged = new List<int>();
            int i = 0;
            int j = 0;

            while (i < a.Count & j < b.Count)
            {
                if (a[i] < b[j])
                {
                    merged.Insert(i + j, a[i]);
                    i++;
                }
                else
                {
                    merged.Insert(i + j, b[j]);
                    j++;
                }
            }
            if (i == a.Count)
            {
                merged.AddRange(b.GetRange(j, b.Count - j));
            }
            else
            {
                merged.AddRange(a.GetRange(i, a.Count - i));
            }
            return merged;
        }
    }
}
