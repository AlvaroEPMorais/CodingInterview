using System.Text;

namespace ArraysAndStrings
{
    internal static class RemoveSpecifiedCharacteres
    {
        public static string Method_1(string str, string rem)
        {
            StringBuilder strRet = new StringBuilder();
            bool[] flags = new bool[256];
            foreach (var ch in rem)
            {
                flags[ch] = true;
            }
            foreach (var ch in str)
            {
                if (!flags[ch])
                    strRet.Append(ch);
            }
            return strRet.ToString();
        }
    }
}