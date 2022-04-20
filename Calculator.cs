using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula60Exe84
{
    internal class Calculator
    {
        public static int[] sumArrays(int[] arrayA, int[] arrayB)
        {
            return arrayA.Zip(arrayB, (x, y) => x + y).ToArray();
        }
    }
}
