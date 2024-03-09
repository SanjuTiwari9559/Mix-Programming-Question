namespace OverLoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add(10, 10);
            add(20, 10.3f);
        }
        public static int add(int x, int y)
        {
            return x + y;
        }
        public static float add(int x, float y)
        {
            return x + y;
        }
        public static float add(int x, float y,int z)
        {
            return x + y+z;
        }
    }
}
