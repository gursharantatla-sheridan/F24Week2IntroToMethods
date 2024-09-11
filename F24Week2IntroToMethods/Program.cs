namespace F24Week2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string s = "hello";
            int[] a = { 4, 3, 6, 5, 2, 7, 8 };

            Console.WriteLine("Before changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("a[0] = " + a[0]);

            ChangeValue(ref n, s, a);

            Console.WriteLine("\nAfter changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("a[0] = " + a[0]);

            Console.WriteLine("\n\n");



            int p = 4, q = 6;
            int sum, mul;

            Calculate(p, q, out sum, out mul);

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Mul = " + mul);
        }


        static void Calculate(int x, int y, out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;
        }


        static void ChangeValue(ref int num, string str, int[] arr)
        {
            num = 100;
            str = "bye";
            arr[0] = 100;
        }
    }
}
