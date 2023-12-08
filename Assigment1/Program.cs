namespace Assigment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 99; i > 1; i--)
            {
                Console.WriteLine($"{(i)} bottles of beer on the wall,");
                Console.WriteLine($"{(i)} bottles of beer.");
                Console.WriteLine("Take one down, pass it around,");

            }

            for (int i = 1; i > 0; i--)
            {
                Console.WriteLine($"{(i)}bottle of beer on the wall,");
                Console.WriteLine($"{(i)}bottle of beer.");
            }
        }
    }
}
