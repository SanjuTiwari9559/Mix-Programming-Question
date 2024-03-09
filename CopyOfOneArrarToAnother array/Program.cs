namespace CopyOfOneArrarToAnother_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int [] arr= {1,2,3,4,5};
            int[] arr2 =  new int[arr.Length];
           // Array.Copy(arr, arr2, arr.Length);
           Array.Copy(arr,1,arr2,1,arr.Length);
            foreach(int i in arr2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
