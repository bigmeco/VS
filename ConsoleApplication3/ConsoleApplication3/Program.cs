using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            float s = 0F; //Сумма, погрешность, н-ый член ряда
            float eps;
            float Fp;
            int n = 1; //iter-количество итераций
            int iter = 0;
            Console.Write("Vvedite pogreshost\n");
            eps = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
            Fp = eps;
            while (Math.Abs(Fp) >= eps)
            {
                Fp = (1 / Math.Pow(1 * Math.Log(Math.Sin(1 / n)), 2));
                if (Math.Abs(Fp) < eps)
                {
                    break;
                }
                s = s + Fp;
                n++;
                iter++;
            }
            if (iter == 0)
            {
                Console.Write("Vichislit nevozmojno");
            }
            else
            {
                Console.Write("Summa ");
                Console.Write(s);
                Console.Write('\n');
                Console.Write("Kol-vo iteracyi ");
                Console.Write(iter);
            }

            Дано натуральное число N.Вычислить int i, k, N;
            float S = 0F;
            float A;
            Console.Write("Vvedite naturalnoe chislo\n");
            N = ConsoleInput.ReadToWhiteSpace(true);

            for (i = 1; i <= N; i++)
            {
                A = 0F;
                for (k = 1; k <= i; k++)
                {
                    A += Math.Pow((i * (i + k) / k), k);
                }
                S += A;
            }

            Console.Write("\nS=");
            Console.Write(S);

//----------------------------------------------------------------------------------------
//	Copyright © 2006 - 2016 Tangible Software Solutions Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class provides the ability to convert basic C++ 'cin' and C 'scanf' behavior.
//----------------------------------------------------------------------------------------
        internal static class ConsoleInput
        {
            private static bool goodLastRead = false;
            internal static bool LastReadWasGood
            {
                get
                {
                    return goodLastRead;
                }
            }

            internal static string ReadToWhiteSpace(bool skipLeadingWhiteSpace)
            {
                string input = "";

                char nextChar;
                while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
                {
                    //accumulate leading white space if skipLeadingWhiteSpace is false:
                    if (!skipLeadingWhiteSpace)
                        input += nextChar;
                }
                //the first non white space character:
                input += nextChar;

                //accumulate characters until white space is reached:
                while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
                {
                    input += nextChar;
                }

                goodLastRead = input.Length > 0;
                return input;
            }

            internal static string ScanfRead(string unwantedSequence = null, int maxFieldLength = -1)
            {
                string input = "";

                char nextChar;
                if (unwantedSequence != null)
                {
                    nextChar = '\0';
                    for (int charIndex = 0; charIndex < unwantedSequence.Length; charIndex++)
                    {
                        if (char.IsWhiteSpace(unwantedSequence[charIndex]))
                        {
                            //ignore all subsequent white space:
                            while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
                            {
                            }
                        }
                        else
                        {
                            //ensure each character matches the expected character in the sequence:
                            nextChar = (char)System.Console.Read();
                            if (nextChar != unwantedSequence[charIndex])
                                return null;
                        }
                    }

                    input = nextChar.ToString();
                    if (maxFieldLength == 1)
                        return input;
                }

                while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
                {
                    input += nextChar;
                    if (maxFieldLength == input.Length)
                        return input;
                }

                return input;
            }
        }

    }
}

