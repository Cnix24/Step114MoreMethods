using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step114MoreMethods
{
    public class MethodClass
    {
        public int Operation(int x)
        {
            int answer = x + 33;
            return answer;
        }
        public int Operation(double x)
        {
            double integerAnswer = x + 12;
            int answer = Convert.ToInt32(integerAnswer);
            return answer;
        }
        public int Operation(string x)
        {
            int integerX = Convert.ToInt32(x);
            int answer = integerX + 95;

            return answer;
        }
    }
}
