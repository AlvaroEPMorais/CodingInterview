using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine("Book Solution string com letra minuscula");
            Console.WriteLine(IsUnique.BookSolution("abcdefghijklmnopqrstvwxyz"));// True
            Console.WriteLine(IsUnique.BookSolution("abcdefghijklmnopqrstvwxyzzz"));// False 2 ZZ
            Console.WriteLine("#############################################");
            Console.WriteLine("Check Permutation");
            Console.WriteLine("Method_1");
            Console.WriteLine(CheckPermutation.Method_1("roma","amor"));// True
            Console.WriteLine(CheckPermutation.Method_1("tact coa", "taco cat"));// True
            Console.WriteLine(CheckPermutation.Method_1("roma", "amoe"));// False
            Console.WriteLine(CheckPermutation.Method_1("tact coa", "taco cae"));// False
            Console.WriteLine("Method_1 Ignore Case");
            Console.WriteLine(CheckPermutation.Method_1_IngoreCase("Roma", "Amor"));// True
            Console.WriteLine(CheckPermutation.Method_1_IngoreCase("Tact Coa", "taco cat"));// True
            Console.WriteLine(CheckPermutation.Method_1_IngoreCase("Roma", "Amoe"));// False
            Console.WriteLine(CheckPermutation.Method_1_IngoreCase("Tact Coa", "taco cae"));// False
            Console.WriteLine("Book Solution");
            Console.WriteLine(CheckPermutation.BookSolution("roma", "amor"));// True
            Console.WriteLine(CheckPermutation.BookSolution("tact coa", "taco cat"));// True
            Console.WriteLine(CheckPermutation.BookSolution("roma", "amoe"));// False
            Console.WriteLine(CheckPermutation.BookSolution("tact coa", "taco cae"));// False
            Console.WriteLine("#############################################");
            Console.WriteLine("URLify");
            Console.WriteLine("Method_1");
            Console.WriteLine(URLify.Method_1("Mr John Smith"));//
            Console.WriteLine(URLify.Method_1("1Espace 2Espacos  3Espacos   4Espacos    "));//
            Console.WriteLine("Book Solution");
            char[] str = "Mr John Smith    ".ToCharArray();
           // URLify.BookSolution(str, 13);
            Console.WriteLine(str);//
            Console.WriteLine("#############################################");
            Console.WriteLine("Palindrome Permutation");
            Console.WriteLine(PalindromePermutation.Method_1("Tact Coa"));//
            Console.WriteLine(PalindromePermutation.Method_2("Tact Coa"));//
            Console.ReadLine();
        }
    }
}
