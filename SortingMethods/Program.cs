using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 14, 2, 13, 4, 9, 10, 7, 8, 5, 6, 11, 12, 3, 1 };
            Console.WriteLine($"[ {String.Join(", ", list)} ]");

            Console.WriteLine("BUBBLE");
            Bubble bubbleSort = new Bubble(list);


            Console.WriteLine("MERGE");
            Merge mergeSort = new Merge(list);
            Console.WriteLine($"[ {String.Join(", ", mergeSort.SortedList)} ]");
        }
    }
}
