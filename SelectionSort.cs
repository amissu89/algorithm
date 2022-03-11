using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithm.Sort
{
    class SelectionSort
    {
        public static List<int> sort(List<int> arr)
        {
            List<int> newArr = new List<int>();
            while(arr.Count != 0)
            {
                Console.WriteLine("Count : " + arr.Count);
                int smallest = findSmallest(arr);
                if (smallest < 0)
                    continue;
                newArr.Add(arr[smallest]);
                arr.RemoveAt(smallest);
            }
            return newArr;
        }

        public static int findSmallest(List<int> arr)
        {
            int smallest = arr[0];
            int smallest_idx = Constants.NOK;

            foreach (var item in arr.Select((value, index) => new { Val = value, Idx=index }))
            {
                if(item.Val < smallest)
                {
                    smallest = item.Val;
                    smallest_idx = item.Idx;
                }
            }

            Console.WriteLine($"smallest : {smallest} , smallest.idx : {smallest_idx}");
            return smallest_idx;
        }
    }
}
