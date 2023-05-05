using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Functions
{
    internal class CharacterStorageFunc
    {
        public static int CharacterStorage(string input)
        {
            char[] operators = new char[] { '+', '-', '*', '/', '%', '^' };

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (operators.Contains(c))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
