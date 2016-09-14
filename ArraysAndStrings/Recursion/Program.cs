using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
                EigthQueenProblem board = new EigthQueenProblem(9, 8);
                board.Solve();
           
            //String test = "a";
            //StringPermutation stringPermutation = new StringPermutation(test);
            //for (char i = 'b'; i <= 'f'; ++i)
            //{
            //    test = test + i;
            //  stringPermutation = new StringPermutation(test);
            //}
        }
    }
}
