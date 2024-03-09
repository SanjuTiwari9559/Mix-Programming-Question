namespace MergeToArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 4, 8, 6 };
            int[] arr2 = { 1,2, 4, 8 };
           List<int> list1= MergeArray(arr1, arr2);
            foreach(int i in list1)
            {
                Console.WriteLine(i);
            }

        }
        public static List<int> MergeArray(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            int i = 0, j = 0;
            while(i< arr1.Length && j<arr2.Length) {
                if (arr1[i] < arr2[j])
                {
                    result.Add(arr1[i]);
                    i++;
                }
                else
                {
                    result.Add(arr1[j]);
                    j++;
                }

                
            }
            if(i< arr1.Length )
            {
                result.Add(arr1[i] );
                i++;
            }
            if(j< arr2.Length )
            {
                result.Add(arr2[j] );
                j++;
            }

            return result;
        }
    }
}
