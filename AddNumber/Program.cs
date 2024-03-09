namespace AddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int sum= Add(10);
            Console.WriteLine(sum);
        }
        public  static int Add(int num)

        {
            int totalSum = 0;
                int i = 1;
            while(i<=num)
            {
                totalSum=totalSum+i;
                i++;

            }
            return totalSum;
        }
    }
}
