using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordTranspositionCipher
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            while (N > 0)
            {
                --N;
                String keyWord = Console.ReadLine();
                String[] cText = Console.ReadLine().Split(' ');
                List<char> myStuff = new List<char>();
                foreach (char ch in keyWord.ToUpperInvariant())
                {
                    if (!myStuff.Contains(ch))
                    {
                        myStuff.Add(ch);
                    }
                }
                int keyWordLenght = myStuff.Count;
                for (int i = 'A'; i <= 'Z'; ++i)
                {
                    if (!myStuff.Contains((char) i))
                    {
                        myStuff.Add((char) i);
                    }
                }
                Dictionary<char,List<char>> auxDictionary = new Dictionary<char, List<char>>();
                for (int i = 0; i < keyWordLenght; ++i)
                {
                    int index = i;
                    char ch = myStuff[index];
                    index = index + keyWordLenght;
                    List < char > auxList = new List<char>();
                    while (index < myStuff.Count)
                    {
                        auxList.Add(myStuff[index]);             
                        index = index + keyWordLenght;
                    }
                    auxDictionary.Add(ch, auxList);                 
                }
                Dictionary<char,char> myAlphabet = new Dictionary<char, char>();
                List<char> keys = auxDictionary.Keys.ToList().OrderBy(d => d).ToList();
                char chAux = 'A';
                foreach (var auxKey in keys)
                {
                    List<char> locChar = auxDictionary[auxKey];
                    myAlphabet.Add(auxKey,chAux);
                    foreach (char ch in locChar)
                    {
                        ++chAux;
                        myAlphabet.Add( ch,(char)chAux);
                    }
                    ++chAux;
                }
                //foreach (var auxKey in myAlphabet.Keys)
                //{
                //    Console.Write(auxKey + " ");
                //}
                //Console.WriteLine();
                //foreach (var auxKey in myAlphabet.Values)
                //{
                //    Console.Write(auxKey + " ");
                //}
                foreach (string str in cText)
                {
                    foreach (var ch in str)
                    {
                        Console.Write(myAlphabet[ch]);
                    }
                    Console.Write(" ");
                }
            }
        }
    }
}
