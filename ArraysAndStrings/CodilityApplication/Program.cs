using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stderr for debugging purposes, e.g.
// Console.Error.WriteLine("this is a debug message");

class Solution
{
    
    static void Main(string[] args)
    {
        solution("00:01:07,400-234-090\n"+
   "00:05:01, 701 - 080 - 080\n"+
   "00:05:00, 400 - 234 - 090");
        Console.ReadLine();
    }
    public static int solution(String S)

    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        String[] numerosTelefone = S.Split('\n');
        int custoTotal = 0;
        Dictionary<int,int> dataTotal = new Dictionary<int, int>();
        foreach (String data in numerosTelefone)
        {
            int custo = 0;
            String[] dataTelefonemas = data.Split(',');
           
            String[] duracaoTele = dataTelefonemas[0].Split(':');
           
            int horas = Convert.ToInt32(duracaoTele[0]);
            int minutos  = Convert.ToInt32(duracaoTele[1]);
            int segundos = Convert.ToInt32(duracaoTele[2]);
            if (horas == 0 && minutos <= 5)
            {
                custo = (minutos*60+segundos)*3;
            }
            else
            {
                minutos = horas * 60 + minutos;
                if (segundos > 0)
                    ++minutos;
                custo = minutos  * 150;
            }

            String aux = String.Empty;
            String[] stringNumero = dataTelefonemas[1].Split('-');
            foreach (var str in stringNumero)
            {
                aux = aux + str.Trim();
            }
            int numTeleleAux = Convert.ToInt32(aux);
            if (dataTotal.ContainsKey(numTeleleAux))
            {
                dataTotal[numTeleleAux] = dataTotal[numTeleleAux] + custo;
            }
            else
            {
                dataTotal.Add(numTeleleAux,custo);
            }
            custoTotal = custoTotal + custo;
            custo = 0;
        }
        int max = int.MinValue;
        int numTele = int.MaxValue;
        List<int> chaves = dataTotal.Keys.ToList();
        for(int index= 0;index<chaves.Count;++index)
        {
            int chaveLocal = chaves[index];
            int custoLocal = dataTotal[chaveLocal];
            if (max < custoLocal)
            {
                max = custoLocal;
            }
            if (max == custoLocal && numTele > chaveLocal)
            {
                max = custoLocal;
            }
        }
        return custoTotal - max;
    }

}


//public static void solution(int N)
//{
//    // write your code in C# 6.0 with .NET 4.5 (Mono)
//    if (N > 1)
//    {
//        bool flag = false;
//        for (int index = 1; index <= N; ++index)
//        {
//            flag = false;
//            if (index % 3 == 0)
//            {
//                flag = true;
//                Console.Write("Fizz");
//            }
//            if (index % 5 == 0)
//            {
//                flag = true;
//                Console.Write("Buzz");
//            }
//            if (index % 7 == 0)
//            {
//                flag = true;
//                Console.Write("Woof");
//            }
//            if (flag)
//                Console.WriteLine();
//            else
//                Console.WriteLine(index);
//        }
//    }
//}
