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
            //int sum, mul;

            Calculate(p, q, out int sum, out int mul);

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Mul = " + mul);


            //Console.Write("\n\nEnter a number: ");
            //if (int.TryParse(Console.ReadLine(), out int x))
            //    Console.WriteLine("x = " + x);
            //else
            //    Console.WriteLine("Invalid input. Please try again.");


            Console.WriteLine("\n\np = " + p + ", q = " + q);
            Console.WriteLine($"p = {p}, q = {q}");
            Console.WriteLine("p = {0}, q = {1}", p, q);



            PrintArray(a);
            PrintArray(3, 4, 5, 76, 8, 9, 8, 5, 6, 5, 4, 3, 4);
        }



        static void PrintArray(params int[] arr)
        {
            Console.WriteLine("\n\nNumber of items: " + arr.Length);

            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
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
