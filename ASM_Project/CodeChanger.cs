using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_Project
{
    internal class CodeChanger
    {
        BaseChanger changer = new BaseChanger();

        public string convertDecimalToBinary(int decimalInput)
        {
            return changer.convertDecimalToTargetBase(decimalInput, 2);
        }

        public int convertBinaryToDecimal(string binaryInput)
        {
            return changer.convertToDecimal(binaryInput, 2);
        }

        public string saveTo4Bit(String input)
        {
            string s = "";
            char[] chars = input.ToCharArray();
            int d = 0;
            while ((chars.Length + d)!= 4)
            {
                s = s + '0';
                d++;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                s = s + chars[i];
            }
            return s;
        }

        public List<string> split4bit4bit(string binaryCodedInput)//input in NOT decimal, add zero to the right side of number then split the number
        {
            char[] c = binaryCodedInput.ToCharArray();
            int d = 0;
            List<char> list = new List<char>();
            List<string> list2 = new List<string>();
            while ((c.Length + d) % 4 != 0)
            {
                d++;
                list.Add('0');
            }
            for (int i = 0; i < c.Length; i++)
            {
                list.Add(c[i]);
            }
            string ss = "";
            for (int i = 0; i < list.Count; i++)
            {
                ss = ss + list[i];
                if ((i + 1) % 4 == 0)
                {
                    list2.Add(ss);
                    ss = "";
                }

            }
            return list2;
        }  


        public string convertEx_3ToBinary(string ex_3Input)
        {
            string temp = "";
            List<string> list = split4bit4bit(ex_3Input);
            for(int i = 0; i < list.Count; i++)
            {
                list[i] = Convert.ToString(convertBinaryToDecimal(list[i]) - 3);
                temp = temp + list[i];
            }
            return convertDecimalToBinary(Convert.ToInt32(temp));
        }

        public string convertBinaryToEx_3(string binaryInput)
        {

            int de = convertBinaryToDecimal(binaryInput);//de == decimal
            int quotient = 0, remainder;
            List<string> list = new List<string>();
            string output = "";

            while (de >= 10)
            {
                quotient = de / 10;
                remainder = de % 10;
                list.Add(saveTo4Bit(convertDecimalToBinary(remainder + 3)));
                de = quotient;
            }

            remainder = quotient;//to add least  digit
            list.Add(saveTo4Bit(convertDecimalToBinary(remainder + 3)));

            list.Reverse();
            foreach (string str in list)
            {
                output = output + str;
                output += " ";
            }

            return output;
        }


        public string convertBinaryToGray(string binaryInput)
        {
            char[] chars = binaryInput.ToCharArray();
            string outPut = "";
            int index;
            for (index = chars.Length -1;index -1 >= 0; index--)
            {
                outPut = outPut + (chars[index -1] ^ chars[index]);
            }
            if(index -2 < 0)
            {
                outPut = outPut + char.GetNumericValue(Convert.ToChar(chars[index] ^ 0));
            }
            
            return new string(outPut.ToCharArray().Reverse().ToArray());
        }

        public string convertGaryToBinary(string grayInput)
        {
            string outPut = "";
            int index = 1;
            char[] chars = grayInput.ToCharArray();
            int temp = (int)char.GetNumericValue(chars[0]);
            outPut += temp;
            for (; index < chars.Length; index++)
            {
                temp = temp ^ (int)char.GetNumericValue(chars[index]);
                outPut += Convert.ToString(temp);
            }
            return outPut;
        }


        public int convertBCDToDecimal(string BCDInput)
        {
            List<string> digits = split4bit4bit(BCDInput);
            string outPut = "";
            foreach (string digit in digits)
            {
                outPut += convertBinaryToDecimal(digit);
            }
            return Convert.ToInt32(outPut);
        }

        public string convertDecimalToBCD(int decimalInput)
        {
            string outPut = "";
            string input = Convert.ToString(decimalInput);
            string s;
            for(int i = 0; i < input.Length; i++)
            {
                s = Convert.ToString(input.ElementAt(i));

                outPut += saveTo4Bit(convertDecimalToBinary(Convert.ToInt32(s)));
                outPut += " ";
            }

            return outPut;
        }


        public string convertDecimalTo2421(string decimalInput)
        {
            string outPut = "";

            for(int i = 0;i < decimalInput.Length; i++)
            {
                switch (decimalInput.ElementAt(i))
                {
                    case '0':
                        outPut += "0000";
                        break;
                    case '1':
                        outPut += "0001";
                        break;
                    case '2':
                        outPut += "0010";
                        break;
                    case '3':
                        outPut += "0011";
                        break;
                    case '4':
                        outPut += "0100";
                        break;
                    case '5':
                        outPut += "1011";
                        break;
                    case '6':
                        outPut += "1100";
                        break;
                    case '7':
                        outPut += "1101";
                        break;
                    case '8':
                        outPut += "1110";
                        break;
                    case '9':
                        outPut += "1111";
                        break;
                }
                outPut += " ";
            }
            return outPut;
        }

        public string convert2421ToDecimal(string input)
        {
            List<string> list = split4bit4bit(input);
            string outPut = "";

            foreach(string str in list)
            {
                switch (str)
                {
                    case "0000":
                        outPut += "0";
                        break;
                    case "0001":
                        outPut += "1";
                        break;
                    case "0010":
                        outPut += "2";
                        break;
                    case "0011":
                        outPut += "3";
                        break;
                    case "0100":
                        outPut += "4";
                        break;
                    case "1011":
                        outPut += "5";
                        break;
                    case "1100":
                        outPut += "6";
                        break;
                    case "1101":
                        outPut += "7";
                        break;
                    case "1110":
                        outPut += "8";
                        break;
                    case "1111":
                        outPut += "9";
                        break;
                }
            }
            return outPut;
        }


    }
}
