using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Data_Encryption_Compression_Simulator.ClassLib
{
    class Compression
    {
        public byte[] GetBytes(string bitString) //this will take a string of 1s and 0s as argument and convert it into array of string and return it. 
        {
            byte[] output;

            output = new byte[(bitString.Length / 8)];


            for (int i = 0; i < output.Length; i++)
            {
                for (int b = 0; b <= 7; b++)//this loop will convert each of the 0 and 1 into appropriat position
                {
                    output[i] |= (byte)((bitString[i * 8 + b] == '1' ? 1 : 0) << (7 - b));
                }
            }
            return output;
        }

        public string ArrangeString(BitArray unaranged)
        {
            StringBuilder sbw = new StringBuilder();

            for (int i = 1; i < unaranged.Length / 8 + 1; i++)
            {

                for (int j = i * 8 - 1; j > i * 8 - 9; j--)
                {
                    int pr = Convert.ToInt32(unaranged[j]);
                    sbw.Append(pr.ToString());
                }
            }
            string str = sbw.ToString();
            return str;
        }

        public string Coding(string st)//for conversion of 0-9 string into huffman.
        {
            //StringBuilder sbForAppend = new StringBuilder();
            //st=(sbForAppend.Append(st+"0000000")).ToString();//this addition is done after some of the changes may tends to replce if error
            char[] ch = st.ToArray();
            StringBuilder sbC = new StringBuilder();
            string str;
            for (int i = 0; i < st.Length; i++)
            {
                if (ch[i] == ',')
                { sbC.Append("011"); }

                else if (ch[i] == '0')
                { sbC.Append("010"); }

                else if (ch[i] == '1')
                { sbC.Append("100"); }

                else if (ch[i] == '2')
                { sbC.Append("1010"); }
                else if (ch[i] == '3')
                { sbC.Append("1011"); }
                else if (ch[i] == '4')
                { sbC.Append("1100"); }
                else if (ch[i] == '5')
                { sbC.Append("1101"); }
                else if (ch[i] == '6')
                { sbC.Append("11100"); }
                else if (ch[i] == '7')
                { sbC.Append("11101"); }
                else if (ch[i] == '8')
                { sbC.Append("11110"); }
                else if (ch[i] == '9')
                { sbC.Append("11111"); }
            }
            str = sbC.ToString();
            return str;
        }

        public string DeCoding(string st)
        {
            StringBuilder sbcc = new StringBuilder();

            char[] ch = st.ToArray();

            for (int i = 0; i < ch.Length - 1; )
            {
                if (ch[i] == '1')
                {
                    i++;
                    if (ch[i] == '1')
                    {
                        i++;
                        if (ch[i] == '1')
                        {
                            i++;
                            if (ch[i] == '1')
                            {
                                i++;
                                if (ch[i] == '1')
                                {
                                    i++;
                                    sbcc.Append("9");
                                }
                                else if (ch[i] == '0')
                                {
                                    i++;
                                    sbcc.Append("8");
                                }
                            }
                            else if (ch[i] == '0')
                            {
                                i++;
                                if (ch[i] == '1')
                                {
                                    i++;
                                    sbcc.Append("7");
                                }
                                else if (ch[i] == '0')
                                {
                                    i++;
                                    sbcc.Append("6");
                                }


                            }
                        }
                        else if (ch[i] == '0')
                        {
                            i++;
                            if (ch[i] == '1')
                            {
                                i++;
                                sbcc.Append("5");
                            }
                            else if (ch[i] == '0')
                            {
                                i++;
                                sbcc.Append("4");
                            }
                        }
                    }
                    else if (ch[i] == '0')
                    {
                        i++;
                        if (ch[i] == '0')
                        {
                            i++;
                            sbcc.Append("1");
                        }
                        else if (ch[i] == '1')
                        {
                            i++;
                            if (ch[i] == '1')
                            {
                                i++;
                                sbcc.Append("3");
                            }
                            else if (ch[i] == '0')
                            {
                                i++;
                                sbcc.Append("2");
                            }
                        }

                    }
                }
                else if (ch[i] == '0')
                {
                    i++;
                    if (ch[i] == '1')
                    {
                        i++;
                        if (ch[i] == '1')
                        {
                            i++;
                            sbcc.Append(",");
                        }
                        else if (ch[i] == '0')
                        {
                            i++;
                            sbcc.Append("0");
                        }
                    }
                }
                //else if (ch[i] == '0')
                //{ i++; }

            }

            string stFor = sbcc.ToString();
            return stFor;
        }
    }
}
