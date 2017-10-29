using System;

namespace FizzbuzzKata
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Fizzbuzz Kata ....");

            var fizzbuzzGenerator = new FizzbuzzGenerator();

            fizzbuzzGenerator
                .GenerateResults(1, 100)
                .ForEach(r => Console.WriteLine(r));

            Console.ReadLine();
            return 0;
        }
    }
}
