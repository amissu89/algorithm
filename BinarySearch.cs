namespace Algorithm.Search
{
    /*
     Binary Search
     input : Sorted Array
     output : find - idx, not find - -1
     */

    class BinarySearch
    {
        public static int Search(int[] arr, int num, ref int howmany)
        {
            int low = 0;
            int high = arr.Length - 1;
            while( low <= high)
            {
                int mid = (low + high) / 2;
                int guess = arr[mid];
                if(guess == num)
                {
                    return mid;
                }
                else if(guess < num)
                {
                    howmany++;
                    low = mid + 1;
                }
                else if(guess > num)
                {
                    howmany++;
                    high = mid - 1;
                }
            }
            return Constants.NOK;
        }
    }
}
