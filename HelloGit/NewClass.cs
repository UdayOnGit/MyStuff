using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class NewClass
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Add comments for Subtract
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// Add comments for Multiply function
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
