using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Functions
{
    internal class TransformationFunc
    {
        public static double ParseOperand(string input)
        {
            return double.Parse(input);
        }
    }
}
