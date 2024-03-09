namespace AllZeroRightSide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 14, 0, 76, 0, 45, 0, 9, 4, 0, 5 };
             
         int [] arr2  = AllZeroRightSide(arr1);
            foreach (int i in arr2) { 
                Console.WriteLine(i);
            }
        }
        public static int[] AllZeroRightSide(int[] arr1)
        {
            int NonZero = 0;
            for(int i=0; i<arr1.Length; i++)
            {
                if (arr1[i] !=0)
                {
                    arr1[NonZero++] = arr1[i];
                }


            }
            for(int i=NonZero; i<arr1.Length; i++)
            {
                arr1[NonZero++] = 0;
            }

            return arr1;
        }
    }
}
