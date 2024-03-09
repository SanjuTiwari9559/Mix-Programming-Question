namespace BobbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr2 = { 1, 2, 5, 8, 3, 7 };
            int [] arr3=Bubble(arr2);
            foreach (int i in arr3)
            {
                Console.Write(i + " ");
            }
        }
        public static int[] Bubble(int[] arr)
        {
            for(int i=0; i<arr.Length-1; i++) {
                for(int j=0;j<arr.Length-i-1; j++) {
                    if (arr[j] >arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
