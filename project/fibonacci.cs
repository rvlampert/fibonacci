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
