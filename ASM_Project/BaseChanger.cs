using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_Project
{
    internal class BaseChanger
    {
        public string changer(string input,int currentBase, int targetBase)
        {

            return null;
        }

        public int convertToDecimal(string input, int currentBase)
        {
            char[] temp = input.ToCharArray();
            List<int> result = new List<int>();
            int len = temp.Length;
            int pow = 0;
            int x,calculate;
            for (int i = len - 1 ;i >= 0; i--)
            {
                x = (int)char.GetNumericValue(temp[i]);
                if (x != 0)
                {
                    calculate = (int)Math.Pow(currentBase, pow);
                    calculate = calculate * x;
                    result.Add(calculate);
                }
                pow++;
            }
            return result.Sum();
        }

        public int convertHexToDecimal(string input)
        {
            char[] temp = input.ToCharArray();
            List<int> result = new List<int>();
            int len = temp.Length;
            int calculate, x = 0, pow = 0;
            for (int i = len - 1 ; i >= 0; i--)
            {
                if (char.IsLetter(temp[i]))
                {
                    switch (temp[i])
                    {
                        case 'A':
                        case 'a':
                            x = 10;
                            break;
                        case 'B':
                        case 'b':
                            x = 11;
                            break;
                        case 'C':
                        case 'c':
                            x = 12;
                            break;
                        case 'D':
                        case 'd':
                            x = 13;
                            break;
                        case 'E':
                        case 'e':
                            x = 14;
                            break;
                        case 'F':
                        case 'f':
                            x = 15;
                            break;
                    }
                }
                else
                {
                    x = (int)char.GetNumericValue(temp[i]);
                }

                if(x != 0)
                {
                    calculate = (int)Math.Pow(16, pow);
                    calculate = calculate * x;
                    result.Add(calculate);
                }
                pow++;

            }

            return result.Sum();
        }

        public string convertDecimalToTargetBase(int input, int targetBase)
        {
            if (input < targetBase)
            {
                return remainderToString(input);
            }
            List<string> result = new List<string>();
            int quotient = 0, remainder, tempInput = input;

            while (tempInput >= targetBase)
            {
                quotient = tempInput / targetBase;
                remainder = tempInput % targetBase;
                result.Add(remainderToString(remainder));
                tempInput = quotient;

            }
            result.Add(remainderToString(quotient));
            result.Reverse();
            return ToString(result);
        }


        private string remainderToString(int remainder)
        {
            string result = "";

            if (remainder >= 10) 
            {
                switch (remainder)
                {
                    case 10:
                        result = "A";
                        break;
                    case 11:
                        result = "B";
                        break;
                    case 12:
                        result = "C";
                        break;
                    case 13:
                        result = "D";
                        break;
                    case 14:
                        result = "E";
                        break;
                    case 15:
                        result = "F"; ;
                        break;
                }
            }
            else
            {
                result = Convert.ToString(remainder);
            }

            return result;
        }



        public string ToString(List<string> l)
        {
            string h = "";
            foreach (string v in l)
            {
                h = h + v;
            }
            return h;
        }

        public string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}

