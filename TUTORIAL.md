# Creating .NET Projects
To create a new project
```
dotnet new console -n Project
```
# Creating a makefile
Create a Makefile file in the project directory with the following commands
```
run:
    dotnet run
```
# fibonacci.cs
This file will be responsible for the implementations of the functions related to the fibonacci series itself, such as the calculation of the elements.


We start by declaring the dependencies, the namespace, the Fibonacci class and the functions, one that will return the series and one that will return just the element.
```
using System;
using System.Collections.Generic;
namespace Fibonacci
{
    class Fibonacci_iterative
    {
        public List<int> fibonacci_serie(int index)
        {
        }
        public int fibonacci_value(int index)
        {
        }
    }
}
```
With that done, we implement the functions. The ```fibonacci_serie``` function must return a list with all the elements of the sequence up to a certain position and the ```fibonacci_value``` returns the value of that position in the sequence.

Fibonacci_serie:
```
public List<int> fibonacci_serie(int index)
    {
        List<int> sequence = new List<int>();
        int a = 1;
        int b = 1;
        int c = 0;
        if(index == 1){
            sequence.Add(a);
            return sequence;
        }
        else if(index == 2){
            sequence.Add(a);
            sequence.Add(b);
            return sequence;
        }
        else{
            sequence.Add(a);
            sequence.Add(b);
            for (int i=2;i<index;i++){
                c = a+b;
                a = b;
                b = c;
                sequence.Add(c);
            }
        return sequence;
        }
    }
```
Fibonacci_value:
```
public int fibonacci_value(int index)
    {
        int a = 1;
        int b = 1;
        int c = 0;
        if(index == 1 || index == 2){
            return a;
        }
        else{
            for (int i=2;i<index;i++){
                c = a+b;
                a = b;
                b = c;
            }
        return c;
        }
    }
```
The ```fibonacci.cs``` file should look like this:
```
using System;
using System.Collections.Generic;
namespace Fibonacci
{
    class Fibonacci_iterative
    {
        public List<int> fibonacci_serie(int index)
        {
            List<int> sequence = new List<int>();
            int a = 1;
            int b = 1;
            int c = 0;
            if(index == 1){
                sequence.Add(a);
                return sequence;
            }
            else if(index == 2){
                sequence.Add(a);
                sequence.Add(b);
                return sequence;
            }
            else{
                sequence.Add(a);
                sequence.Add(b);
                for (int i=2;i<index;i++){
                    c = a+b;
                    a = b;
                    b = c;
                    sequence.Add(c);
                }
            return sequence;
            }
        }
        public int fibonacci_value(int index)
        {
            int a = 1;
            int b = 1;
            int c = 0;
            if(index == 1 || index == 2){
                return a;
            }
            else{
                for (int i=2;i<index;i++){
                    c = a+b;
                    a = b;
                    b = c;
                }
            return c;
            }
        }
    }
}
```
# main.cs
Here we need to change the ```main``` function to import the functions and use them. It first creates a list and calls fibonacci_serie then it calls fibonacci_value
```
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
```
The ```main.cs``` looks like this
```
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
```
