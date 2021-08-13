using System;
using Fibonacci;
using System.Collections.Generic;

namespace Main
{
    
            
    class Program
    {
        static void Main(string[] args)
        {
            int index = 4;
            List<int> sequence = new List<int>();
            Fibonacci_iterative fib = new Fibonacci_iterative();
            sequence = fib.fibonacci_serie(index);
            Console.Write("Série: ");
            foreach (int value in sequence){
                Console.Write("|"+value);
            }
            Console.WriteLine("|");
            int final_value = fib.fibonacci_value(index);
            Console.WriteLine("Valor final: "+final_value);

        }
    }
}
