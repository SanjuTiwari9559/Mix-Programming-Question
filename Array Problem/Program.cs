namespace Array_Problem
{
    internal class Program
    {
        static void Main(string[] args) {

            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr1=new int[size];
            fetchValue(arr1);
            PrintArray(arr1 );





        }
        public static void fetchValue(int[] arr1 )
        {
            for(int i=0;i<arr1.Length;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            

        }
        public static void PrintArray(int[] arr1)
        {
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
