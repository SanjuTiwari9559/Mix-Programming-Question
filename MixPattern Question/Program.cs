
// This program is On mix pattern Base Question 
namespace MixPattern_Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for(int i=1; i<=5;i++)
            {
                for(int  j=1; j<=6-i;j++)
                {
                    //int n = j - 4;
                    Console.Write(j);
                }
                Console.WriteLine();
                for(int k=5; k>=i;k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
