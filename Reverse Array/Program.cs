namespace Reverse_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine);
            int[] arr= new int[n];
           int []arr2= fetch(arr);
            Array.Reverse(arr2);
            foreach(int i in arr2)
            {
                Console.WriteLine(i);
            }
          /*  Array.Sort(arr2);

            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
          */
        }
        public static int[] fetch(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }


    }
}
