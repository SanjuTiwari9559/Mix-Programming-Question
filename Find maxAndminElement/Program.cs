namespace Find_maxAndminElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 ,5,4,8,7};
           int max= Find_maxElement(arr1);
            Console.WriteLine(max);
           int min= Find_minElement(arr1);
            Console.WriteLine(min);
        }
        public static int Find_maxElement(int[] arr)
        {
            int max = arr[0];
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            return max;
        }
        public static int Find_minElement(int[] arr2)
        {
            int min = arr2[0];
            for(int i=0;i<arr2.Length; i++)
            {
                if (arr2[i] < min)
                {

                }
            }
            return min;
        }

    }
}
