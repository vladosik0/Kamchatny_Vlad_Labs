using System;
using System.Linq;


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 6, 4, 3, 2, 1, 9, 2, 3, 6, 7, 8 };
            Console.WriteLine("Old sequence: ");
            for(int j=0;j<sequence.Length;j++)
            {
                Console.Write(sequence[j] + " ");
            }
            Console.WriteLine("\nNew sequence: ");
            int i = 0;
            var newSequence = from n in sequence where (n * ++i) > 9 select n * i;
            var reversedSequence = newSequence.Reverse();
            foreach (var n in reversedSequence)
            {
                Console.Write(n+ " ");
            }
            Console.WriteLine();
            
        }
    }
}
