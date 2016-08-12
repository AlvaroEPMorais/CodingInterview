using System;

namespace ArraysAndStrings
{
    //Verifcar se string possui apenas caracteres unicos
    public static class IsUnique
    {
        public static bool Method_1(String str)
        {
            //Primeiro confirmar parametros de entrada
            //E bom confiar mas e melhor confirmar
            if (String.IsNullOrWhiteSpace(str))
            {
                return true;
            }
            //Percorrer a string, nao consigo evitar este passo,
            //usar o valor de char como index de um array de int
            //256 ASCII extendido
            //Pode ficar melhor se tiver um array de booleans, menor consumo de memoria3
            int[] array = new int[256];
            foreach (var ch in str)
            {
                if (array[ch] > 0)
                    return false;
                array[ch] = 1;
            }
            return true;
        }

        public static bool Method_2(String str)
        {
            //Primeiro confirmar parametros de entrada
            //E bom confiar mas e melhor confirmar
            if (String.IsNullOrWhiteSpace(str))
            {
                return true;
            }
            //Percorrer a string, nao consigo evitar este passo,
            //usar o valor de char como index de um array de bool
            //256 ASCII extendido
            //Usar booleans em vez de int
            bool[] array = new bool[256];
            foreach (var ch in str)
            {
                if (array[ch])
                    return false;
                array[ch] = true;
            }
            return true;
        }

        //Força bruta O(N^2)
        public static bool Method_3(String str)
        {
            //Primeiro confirmar parametros de entrada
            //E bom confiar mas e melhor confirmar
            if (String.IsNullOrWhiteSpace(str))
            {
                return true;
            }
            for (int i = 0; i < str.Length - 1; ++i)
            {
                char ch = str[i];
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[j] == ch)
                        return false;
                }
            }
            return true;
        }

        public static bool BestSolution(String str)
        {
            int checker = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                int val = str[i] - 'a';
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }
            return true;
        }
    }
}