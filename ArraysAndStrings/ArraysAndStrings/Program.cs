using System;
using System.Collections.Generic;

namespace ArraysAndStrings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Is Unique");
            Console.WriteLine("Method_1");
            Console.WriteLine(IsUnique.Method_1("abcdefghijklmnopqrstvwxyzABCDEFGHIJKLMNOPQRSTVWXYZ"));// True
            Console.WriteLine(IsUnique.Method_1("abcdefghijklmnopqrstvwxyzABCDEFGHIJKLMNOPQRSTVWXYZZ"));// False 2 ZZ
            Console.WriteLine("Method_2");
            Console.WriteLine(IsUnique.Method_2("abcdefghijklmnopqrstvwxyzABCDEFGHIJKLMNOPQRSTVWXYZ"));// True
            Console.WriteLine(IsUnique.Method_2("abcdefghijklmnopqrstvwxyzABCDEFGHIJKLMNOPQRSTVWXYZZ"));// False 2 ZZ
            Console.WriteLine("Method_3");
            Console.WriteLine(IsUnique.Method_3("abcdefghijklmnopqrstvwxyzABCDEFGHIJKLMNOPQRSTVWXYZ"));// True
            Console.WriteLine(IsUnique.Method_3("abcdefghijklmnopqrstvwxyzABCDEFGHIJKLMNOPQRSTVWXYZZ"));// False 2 ZZ
            Console.WriteLine("Best Solution string com letra minuscula");
            Console.WriteLine(IsUnique.BestSolution("abcdefghijklmnopqrstvwxyz"));// True
            Console.WriteLine(IsUnique.BestSolution("abcdefghijklmnopqrstvwxyzzz"));// False 2 ZZ
            Console.WriteLine("#############################################");
            Console.WriteLine("Check Permutation");
            Console.WriteLine("Method_1");
            Console.WriteLine(CheckPermutation.Method_1("roma", "amor"));// True
            Console.WriteLine(CheckPermutation.Method_1("tact coa", "taco cat"));// True
            Console.WriteLine(CheckPermutation.Method_1("roma", "amoe"));// False
            Console.WriteLine(CheckPermutation.Method_1("tact coa", "taco cae"));// False
            Console.WriteLine("Method_1 Ignore Case");
            Console.WriteLine(CheckPermutation.Method_1_IngoreCase("Roma", "Amor"));// True
            Console.WriteLine(CheckPermutation.Method_1_IngoreCase("Tact Coa", "taco cat"));// True
            Console.WriteLine(CheckPermutation.Method_1_IngoreCase("Roma", "Amoe"));// False
            Console.WriteLine(CheckPermutation.Method_1_IngoreCase("Tact Coa", "taco cae"));// False
            Console.WriteLine("Best Solution");
            Console.WriteLine(CheckPermutation.BestSolution("roma", "amor"));// True
            Console.WriteLine(CheckPermutation.BestSolution("tact coa", "taco cat"));// True
            Console.WriteLine(CheckPermutation.BestSolution("roma", "amoe"));// False
            Console.WriteLine(CheckPermutation.BestSolution("tact coa", "taco cae"));// False
            Console.WriteLine("#############################################");
            Console.WriteLine("URLify");
            Console.WriteLine("Method_1");
            Console.WriteLine(URLify.Method_1("Mr John Smith"));//
            Console.WriteLine(URLify.Method_1("1Espace 2Espacos  3Espacos   4Espacos    "));//
            Console.WriteLine("#############################################");
            Console.WriteLine("Palindrome Permutation");
            Console.WriteLine(PalindromePermutation.Method_1("Tact Coa"));//
            Console.WriteLine(PalindromePermutation.Method_2("Tact Coa"));//
            Console.WriteLine("#############################################");
            Console.WriteLine("OneWay");
            Console.WriteLine("Method_1");
            Console.WriteLine(OneWay.Method_1("pale", "ple"));//true
            Console.WriteLine(OneWay.Method_1("pales", "pale"));//true
            Console.WriteLine(OneWay.Method_1("pale", "bale"));//true
            Console.WriteLine(OneWay.Method_1("pale", "bake"));//false
            Console.WriteLine("Best Solution");
            Console.WriteLine(OneWay.BestSolution("pale", "ple"));//true
            Console.WriteLine(OneWay.BestSolution("pales", "pale"));//true
            Console.WriteLine(OneWay.BestSolution("pale", "bale"));//true
            Console.WriteLine(OneWay.BestSolution("pale", "bake"));//false
            Console.WriteLine("#############################################");
            Console.WriteLine("String Compression");
            Console.WriteLine("Method_1");
            Console.WriteLine(StringCompression.Method_1("aaabbbcccdddeeefffgggaaadddeeefff"));
            Console.WriteLine(StringCompression.Method_1("abcedfghijklmopqrstuv"));
            Console.WriteLine(StringCompression.Method_1("aabcccccaaa"));
            Console.WriteLine("Best Solution");
            Console.WriteLine(StringCompression.BestSolution("aaabbbcccdddeeefffgggaaadddeeefff"));
            Console.WriteLine(StringCompression.BestSolution("abcedfghijklmopqrstuv"));
            Console.WriteLine(StringCompression.BestSolution("aabcccccaaa"));
            Console.WriteLine("#############################################");
            Console.WriteLine("ZeroMatrix");
            ZeroMatrix.Method_1(GenerateMatrix(20)).showMatrix();
            Console.WriteLine("#############################################");
            Console.WriteLine("FirstNonRepeatedCharacter");
            Console.WriteLine(FirstNonRepeatedCharacter.Method_1("total"));//o
            Console.WriteLine(FirstNonRepeatedCharacter.Method_1("teeter"));//r
            Console.WriteLine("#############################################");
            Console.WriteLine("Remove Specified Charateres");
            Console.WriteLine(RemoveSpecifiedCharacteres.Method_1("Battle of the Vowels: Hawaii vs. Grozny", "aeiou"));
            Console.WriteLine(RemoveSpecifiedCharacteres.Method_1("Instituto Sperior de Engenharia de Lisboa", "aeiou"));
            Console.WriteLine("ReverseWords");
            Console.WriteLine(ReverseWords.Method_1("Do or do not, there is no try."));
            Console.WriteLine("#############################################");
            Console.WriteLine("Integer/String Conversion");
            Console.WriteLine("Integer to String Conversion");
            Random ran = new Random((int)DateTime.Now.Ticks);
            List<String> numList = new List<string>();
            for (int i = 0; i < 10; ++i)
            {
                int num = ran.Next(-100, 100);
                numList.Add(IntegerStringConversion.IntToString(num));
                Console.WriteLine(IntegerStringConversion.IntToString(num));
            }
            Console.WriteLine("String to Int Conversion");
            foreach (var num in numList)
            {
                Console.WriteLine(IntegerStringConversion.StringToInt(num));
            }
            Console.WriteLine("#############################################");
            Console.WriteLine("Merge Two Orderded Arrays into one orded Array ");
            int[] array1 = { 1, 3, 5, 7, 9 };
            int[] array2 = { 2, 4, 6, 8 };
            int[] res = MergingTwoArraysInOrder.Method_1(array1, array2);
            ShowIntArray(res);
            int[] array3 = { 1, 3, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int[] array4 = { 2, 4, 6, 8 };
            res = MergingTwoArraysInOrder.Method_1(array3, array4);
            ShowIntArray(res);
            Console.WriteLine("#############################################");
            Console.WriteLine("Reverse Sentece");
            Console.Write("The fox jumps over the fence ->");
            Console.WriteLine(ReverseSetence.Method_1("The fox jumps over the fence"));
            Console.Write("Call me Ismael ->");
            Console.WriteLine(ReverseSetence.Method_1("Call me Ismael"));
            Console.WriteLine("#############################################");
            Console.WriteLine("Max Profit Method 1");
            int[] array5 = { -1, 5, 0, 1, 2, -3 };
            MaxDifferenceProblem.Method_1(array5);
            Console.WriteLine("#############################################");
            MaxDifferenceProblem.Method_1(GenerateRandomArray(10000, 10000, -10000));
            Console.WriteLine("#############################################");
            MaxDifferenceProblem.Method_1(GenerateRandomArray(10000, 10000, -10000));
            Console.WriteLine("Max Profit Method 1");
            int[] array6 = { -1, 5, 0, 1, 2, -3 };
            MaxDifferenceProblem.Method_2(array6);
            Console.WriteLine("#############################################");
            MaxDifferenceProblem.Method_2(GenerateRandomArray(10000, 10000, -10000));
            Console.WriteLine("#############################################");
            MaxDifferenceProblem.Method_2(GenerateRandomArray(10000, 10000, -10000));


            Console.ReadLine();
        }

        private static int[,] GenerateMatrix(int v)
        {
            Random ran = new Random((int)DateTime.Now.Ticks);
            int[,] matrix = new int[v, v];
            for (int i = 0; i < v; ++i)
            {
                for (int j = 0; j < v; ++j)
                {
                    matrix[i, j] = ran.Next(100); ;
                }
            }
            matrix.showMatrix();
            return matrix;
        }

        private static void ShowIntArray(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write(num + " - ");
            }
            Console.WriteLine();
        }

        private static int[] GenerateRandomArray(int size, int max, int min = 0)
        {
            int[] res = new int[size];
            Random ran = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < res.Length; ++i)
            {
                    res[i] = ran.Next(min, max);
            }
            return res;
        }
    }
}