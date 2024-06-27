using System;

namespace Romanos_para_Inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o numero romano: ");   
            string input = Console.ReadLine();
            Solution solution = new Solution();           
            int result = solution.RomanToInt(input);
            Console.WriteLine("O valor do inteiro é: " + result);
        }
    }

    public class Solution
    {
        public int RomanToInt(string s)
        {
            var character = s.ToCharArray();
            int result = 0;

            for (int i = 0; i < character.Length; i++)
            {
                int elemento = RomanNum(character[i]);
                if (i + 1 < character.Length)
                {
                    int nextElemento = RomanNum(character[i + 1]);
                    if (elemento < nextElemento)
                    {
                        result -= elemento;
                    }
                    else
                    {
                        result += elemento;
                    }
                }
                else
                {
                    result += elemento;
                }
            }
            return result;
        }

        private int RomanNum(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
    }
}