using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler146_InvestigatingPrimePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] dataInt = new int[6];
            List<byte> listOfPrimes = getListOfPrimes();        
               
            int T = Convert.ToInt16(Console.ReadLine());          
            for (int index1 = 0; index1 < T; index1++)
            {
                int L = Convert.ToInt32(Console.ReadLine());
                string dataTokens = Console.ReadLine();
                string[] dataTokensSplit = dataTokens?.Split(' ');
                for(int i =0;i<dataInt.Length;++i)
                {
                    dataInt[i] = Convert.ToInt32(dataTokensSplit[i]);                  ;
                }
                if (L <= 10)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    int primeIndex = 100;
                }
            }
            Console.ReadLine();
        }

        private static List<byte> getListOfPrimes()
        {
            byte[] arrayBoo = new byte[Int32.MaxValue];        
            for (UInt64 i = 2; i < (UInt64)arrayBoo.LongLength; ++i)
            {
                if (arrayBoo[i]==0)
                {
                    for (UInt64 j = 2; (i * j) < (UInt64)arrayBoo.LongLength; ++j)
                    {
                        arrayBoo[i*j] = 1;
                    }
                }
            }
            return arrayBoo.ToList();
        }
    }
}
