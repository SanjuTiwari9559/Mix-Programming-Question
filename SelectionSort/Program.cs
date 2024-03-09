namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 7, 8, 3, 4, 5, 6 };
           int [] arr2= SelectionSort(arr);
            foreach (int i in arr2)
            {
                Console.Write(i+" ");
            }
        }
        public static int[] SelectionSort(int[] arr)
        {
            for(int i=0;i<arr.Length-1;i++) { 
                int min = i;
                for(int j=i+1;j<arr.Length;j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min=j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            return arr;
        }
    }
}
