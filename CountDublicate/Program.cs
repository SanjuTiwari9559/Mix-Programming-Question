namespace CountDublicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 7, 8, 2, 2, 3, 4, 8, 7 };
            Dictionary<int ,int> Count=CountDublicate(arr);
            
         foreach(KeyValuePair<int ,int> kvp in Count)
            {
                if(kvp.Value>1)
                {
                    Console.WriteLine($"Dublicate key is {kvp.Key} and its count is {kvp.Value} ");
                }
            }

        }
        public static Dictionary<int, int> CountDublicate(int[] arr)
        {

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (int item in arr)
            {
                if (keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs[item]++;
                }
                else
                {
                    keyValuePairs[item] = 1;
                }
            }
            return keyValuePairs;

        }
    }
}
