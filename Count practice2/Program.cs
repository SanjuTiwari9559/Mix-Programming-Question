using System.Collections.Generic;

namespace Count_practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 7, 8, 9, 1, 2, 3, 8 };
              Dictionary<int,int > keyValuePairs = new Dictionary<int,int>();
            foreach(int i in arr1)
            {
                if(keyValuePairs.ContainsKey(i))
                {
                    keyValuePairs[i]++;
                }
                else
                {
                    keyValuePairs[i] = 1;
                }
            }
            foreach(KeyValuePair<int,int> pair in keyValuePairs)
            {
                if(pair.Value >1)
                {
                    Console.WriteLine($"Dublicate element is {pair.Key}");
                }
            }

        }
    }
}
