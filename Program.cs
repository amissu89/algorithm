using System;
using System.Collections.Generic;
using Algorithm.Search;
using Algorithm.Sort;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> arr = new List<int>(new int[] { 31, 23, 54, 10, 11, 53 });
            int howmany = 0;
            List<int> newArr = SelectionSort.sort(arr);
            //int idx = BinarySearch.Search(arr, 1, ref howmany);
            foreach(var item in newArr)
            {
                Console.Write($"{item} "); 
            }*/

            Approximation apx = new Approximation();
            apx.find();
        }   
    }
}
