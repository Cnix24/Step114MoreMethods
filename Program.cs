using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step114MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodClass integer = new MethodClass();
            int answer = integer.Operation(x: 12);

            Console.WriteLine(answer);

            MethodClass integerTwo = new MethodClass();
            int answerTwo = integerTwo.Operation(x: 99.6);
            
            Console.WriteLine(answerTwo);

            MethodClass integerThree = new MethodClass();
            int answerThree = integerThree.Operation("100");

            Console.WriteLine(answerThree);
        }
    }
}
