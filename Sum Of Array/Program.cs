namespace Sum_Of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 30, 40 };
           int HS= Sum(arr);
            Console.WriteLine(HS);
        }
        public static int Sum(int[] arr)
        {
            int SoE = 0;
            foreach (int i in arr)
            {
                SoE= SoE + i;
            }
            return
                SoE;    
        }
    }
}
