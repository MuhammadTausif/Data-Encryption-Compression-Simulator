using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Encryption_Compression_Simulator
{
    class TypeConversion
    {
        public string CharToInt(string st)
        {
            {
                StringBuilder sb = new StringBuilder();//create a stringbulder
               

                int length = st.Length; //calcuate the length of incoming string of charactor
                if (length >= 1)         //chech that if the length of string st is greater then 1 if yes then convert if
                {
                    char[] integ = st.ToCharArray();//convert string st to chararctor array integ[]
                  
                   
                    for (int i = 0; i < st.Length; i++)// run the loop for length of string 
                    {
                        long iii = Convert.ToInt64(integ[i]);
                        sb.Append(iii.ToString()+",");
                      
                        
                        if (i == st.Length - 1)
                        {
                            sb.Remove(sb.Length - 1, 1);
                        }
                    }

                    string encrypted = sb.ToString();
                    return encrypted;
                }
                else
                {
                    return st;
                }


                //string integ = "Muahmmad Tausif";
                //return integ;
            }
        }
        public string IntToChar(string integ)
        {
            StringBuilder IntToCh = new StringBuilder();
            
            string[] integStringArray = integ.Split(',');
            int messageLength = integStringArray.Length;
            
            for (int i = 0; i < messageLength; i++)
            {
                string chara = integStringArray[i];
                int xa = Convert.ToInt32(chara);
                char cha = (char)xa;
                IntToCh.Append(cha.ToString());
            }

            string encryptedString = IntToCh.ToString();

            return encryptedString;
            
            
        }

        public string EncryptionToCaps(string encryptedNo)
        {
            int lengthOfEn=encryptedNo.Length;
            StringBuilder sb = new StringBuilder();

            char[] ch = encryptedNo.ToCharArray();
            for(int i=0;i<lengthOfEn;i++)
            {
                if (ch[i] == ',')
                {
                    ch[i] = 'A';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == '0')
                {
                    ch[i] = 'B';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == '1')
                {
                    ch[i] = 'C';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == '2')
                {
                    ch[i] = 'D';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == '3')
                {
                    ch[i] = 'E';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == '4')
                {
                    ch[i] = 'F';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == '5')
                {
                    ch[i] = 'G';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == '6')
                {
                    ch[i] = 'H';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == '7')
                {
                    ch[i] = 'I';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == '8')
                {
                    ch[i] = 'J';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == '9')
                {
                    ch[i] = 'K';
                    sb.Append(ch[i].ToString());
                }
                else
                {
                    ch[i]='L';
                }
                
            }
            string caps = sb.ToString();
            
            return caps;
        }
        public string CapsToEncryption(string caps)
        {
            int lengthOfEn = caps.Length;
            StringBuilder sb = new StringBuilder();

            char[] ch = caps.ToCharArray();
            for (int i = 0; i < lengthOfEn; i++)
            {
                if (ch[i] == 'A')
                {
                    ch[i] = ',';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == 'B')
                {
                    ch[i] = '0';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == 'C')
                {
                    ch[i] = '1';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == 'D')
                {
                    ch[i] = '2';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == 'E')
                {
                    ch[i] = '3';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == 'F')
                {
                    ch[i] = '4';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == 'G')
                {
                    ch[i] = '5';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == 'H')
                {
                    ch[i] = '6';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == 'I')
                {
                    ch[i] = '7';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == 'J')
                {
                    ch[i] = '8';
                    sb.Append(ch[i].ToString());
                }
                else if (ch[i] == 'K')
                {
                    ch[i] = '9';
                    sb.Append(ch[i].ToString());
                }
                else
                {
                    ch[i] = 'L';
                }
                
                
            }
            string encryptedNo = sb.ToString();

            return encryptedNo;
            
        }

        
    }
}
