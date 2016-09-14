using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class ReverseSetence
    {
        //"The fox jumps over the fence"
        //"ecnf eht revo spmuj xof ehT"
        public static String Method_1(String str)
        {
            StringBuilder strBu = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; --i)
            {
                strBu.Append(str[i]);
            }
            return strBu.ToString();
        }
    }
}
