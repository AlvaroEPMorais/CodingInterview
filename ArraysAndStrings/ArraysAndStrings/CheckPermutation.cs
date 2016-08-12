using System;

namespace ArraysAndStrings
{
    //Verificar se uma string (permu) é permutacao de outra (orig)
    public static class CheckPermutation
    {
        public static bool Method_1(String orig, String permu)
        {
            //Verificar parametros de entrada
            if (String.IsNullOrEmpty(orig) || String.IsNullOrEmpty(permu) || orig.Length != permu.Length)
            {
                return false;
            }
            //Parecido com isUnique, contar os caracteres de uma string decrementar usando a outra string
            // se no fim alguma posicao tiver valor menor que 0 nao temos permutacao
            int[] array = new int[256];
            foreach (var ch in orig)
            {
                array[ch] += 1;
            }
            foreach (var ch in permu)
            {
                array[ch] -= 1;
                if (array[ch] < 0)
                    return false;
            }

            return true;
        }

        public static bool Method_1_IngoreCase(String orig, String permu)
        {
            //Verificar parametros de entrada
            if (String.IsNullOrEmpty(orig) || String.IsNullOrEmpty(permu) || orig.Length != permu.Length)
            {
                return false;
            }
            //Parecido com isUnique, contar os caracteres de uma string decrementar usando a outra string
            // se no fim alguma posicao tiver valor  menor que 0 nao temos permutacao
            //Vou ingorar maiusculas
            int[] array = new int[256];
            foreach (var ch in orig.ToLowerInvariant())
            {
                array[ch] += 1;
            }
            foreach (var ch in permu.ToLowerInvariant())
            {
                array[ch] -= 1;
                if (array[ch] < 0)
                    return false;
            }

            return true;
        }

        public static bool BestSolution(String orig, String permu)
        {
            if (orig.Length != permu.Length)
            {
                return false;
            }
            int[] letters = new int[256];
            foreach (var ch in orig)
            {
                letters[ch] = letters[ch] + 1;
            }
            foreach (var ch in permu)
            {
                letters[ch] = letters[ch] - 1;
                if (letters[ch] < 0)
                    return false;
            }
            return true;
        }
    }
}