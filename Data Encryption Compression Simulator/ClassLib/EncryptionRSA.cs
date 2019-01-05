using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;


namespace Data_Encryption_Compression_Simulator
{
    class EncryptionRSA 
    {
    
    
        public string KeyGenrator()
        {
            //*****************starts of prime number genrator******************            
            System.Collections.ArrayList arr = new System.Collections.ArrayList();
            int cnt = 1;
            int InnerCnt = 1;
            int InnerDiv = 0;
            for (cnt = 1; cnt < 300; cnt++)
            {
                InnerDiv = 0;
                for (InnerCnt = cnt; InnerCnt > 0; InnerCnt--)
                {
                    if (cnt % InnerCnt == 0)
                        InnerDiv++;
                }
                if (InnerDiv <= 2)
                    arr.Add(cnt);
            }
            //*****************end of Prime Number******************
            int arrayCount = arr.Count-5;
            Random rdn = new Random();
            int randomNoForPrime = rdn.Next(15, arrayCount);

            int p = Convert.ToInt32(arr[randomNoForPrime]);
            int q = Convert.ToInt32(arr[randomNoForPrime+2]);
            int n = p * q;
            int phi = (p - 1)*(q-1);
            
            //********Public Key Genration************
            int e =3;
            Random rde = new Random();
            int randomNoForE = rde.Next(10, arrayCount);
            e = Convert.ToInt32(arr[randomNoForE]);
            if (n / e == 0)
            {
                KeyGenrator();
            }
            //********Private Key Genration***********
            int d = 2;
            int remainder = 0;
            while (remainder != 1)
            {
                d++;
                remainder = (e * d) % phi;
                if(d==phi)//thsi code is written for chek that 'd' is less then 'phi'
                {
                    remainder=1;
                    KeyGenrator();
                }
            }
            

            //********Sending the public and private key********
            string sn=n.ToString();
            string se=e.ToString();
            string sd=d.ToString();

            MessageBox.Show("Congradualtion:\nYou Have Genrated Public and Private Keys Successfuly.\n\nYour\n Public key   :     "+se+","+sn+"\n Private Key  :     "+sd+","+sn+"\n\nPress Ok to Proceede");

            StringBuilder sb=new StringBuilder();
            sb.Append(se+","+sn+"."+sd+","+sn);
            string st=sb.ToString();
            return st;
            }

        public string Encryptor(string message, string key)
        {
           
            StringBuilder encryptedSb = new StringBuilder();
            //*********Key Opration**********
            string[] pbk = key.Split(',');
            string eOfKey, nOfKey;
            long eb=0, nb=0;
            try
            {
               eOfKey = pbk[0];
               nOfKey = pbk[1];
               eb = Convert.ToInt64(eOfKey);
               nb = Convert.ToInt64(nOfKey);
            }
            catch
            {
                MessageBox.Show("You have Entered Wrong key please Enter Correct Key\n\n\n Press OK to proceede");
            }
           
            int c = pbk.Length;

            //************Message Encryption Operation*************
           
            string[] messageStringArray = message.Split(',');
            int messageLength = messageStringArray.Length;

            MessageBox.Show("Now System will Encrypte You Message According to \n\nPublic Key : "+key+"\n\nSystem will use RSA Algorithm to Encrypte It\n\n Pess OK to Proceede");

            for (int i = 0; i < messageLength; i++)
            {
                long m = Convert.ToInt64(messageStringArray[i]);
                //*********Encryption***************
                
                long cipher = mod_exp(m,eb,nb);//method for calculatin remainder

                messageStringArray[i] = cipher.ToString();
                //**********Building of Cipher Text*********

                #region--[this is temporarly removed because of CheckSum]--
                //if (i == messageLength - 1)
                //{
                    //encryptedSb.Append(messageStringArray[i]);
                //}
                //else
                //{
                        encryptedSb.Append(messageStringArray[i] + ",");
                //}
                #endregion
            }

            #region--[in this region key validation code will be added]--

            long cipherPrivateCh = mod_exp(5, eb, nb);
            encryptedSb.Append(cipherPrivateCh.ToString() + ",");

            MessageBox.Show("System Has Genrated a Signature For the Encrypted Text : "+cipherPrivateCh.ToString()+"\n\nThis Signature will be used for your Private Key validation while decryption\n\nPress OK to Proceede");
            #endregion

            #region*******************Adding Check Sum Value********************
            
            long checkSum = 0;
            string forCSum = encryptedSb.ToString();
            char[] integ = forCSum.ToCharArray();
            for (int i = 0; i < forCSum.Length; i++)// run the loop for length of string 
            {
                long iiiii = Convert.ToInt64(integ[i]);
                checkSum= iiiii +checkSum;
            }
            checkSum = checkSum - Convert.ToInt64(',');
            

            encryptedSb.Append(checkSum.ToString());
            MessageBox.Show("System Has Genrated a Check Sum No (by adding all ASCII values of charactars) For the Encrypted Text : " + checkSum.ToString() + "\n\nThis Check Sum will be used for your Text validation while decryption\n\nPress OK to Proceede");
            #endregion****************End of Check Sum Code********************
            string encryptedString = encryptedSb.ToString();
            
            MessageBox.Show("Congradulation:\nYou have Encrypted Text According to RSA.\n\nYour Encrypted Text along with Check Sum value and Signatute are in the text text box.\nPlease use Corresponding Private key for Decryption\n\nPress OK to proceede for Compression  ");
            return encryptedString;
            
        }        

        public string Dencryptor(string messageE, string key)
        {
            StringBuilder dencryptedSb = new StringBuilder();
            //*********Key Opration**********
            string[] pbk = key.Split(',');
            string eOfKey = pbk[0];
            string nOfKey = pbk[1];
            long db = Convert.ToInt64(eOfKey);
            long nb = Convert.ToInt64(nOfKey);
            int c = pbk.Length;



            //************Message Dencryption Opration*************
            string[] messageStringArrayE = messageE.Split(',');
            int messageLength = messageStringArrayE.Length;

            #region--[this is for Private Message cheking]--
            //***************Text validation******************* 
            long checkSumD = 0;
            long checkSumLast = 0;

            char[] integ = messageE.ToCharArray();
            for (int i = 0; i < messageE.Length; i++)// run the loop for length of string 
            {
                long iiiii = Convert.ToInt64(integ[i]);
                checkSumD = iiiii + checkSumD;
            }
            string lastNo=messageStringArrayE[messageLength-1];
            char[] integ2 = lastNo.ToCharArray();
            for (int i = 0; i < lastNo.Length; i++)// run the loop for length of string 
            {
                long iiiii = Convert.ToInt64(integ2[i]);
                checkSumLast = iiiii + checkSumLast;
            }
            checkSumD = checkSumD - checkSumLast - Convert.ToInt64(',') ;

            long mCS = Convert.ToInt64(messageStringArrayE[messageLength - 1]);
            //long cipherCS = mod_exp(mCS, db, nb);
            if (checkSumD != mCS)
            {
                int keyPropfD = 0;

                int b, a = 1;
                b = a / keyPropfD;

            }
            MessageBox.Show("You have entered right text \n press Ok to proceede for key check");
            //*****************Text validation End******************
            #endregion--[this is for Private Message cheking]--
            //***************Key validation******************* 

            string secondlastNo = messageStringArrayE[messageLength - 2];
            long mPrivate = Convert.ToInt64(secondlastNo);
            long cipherPrivateD = mod_exp(mPrivate, db, nb);
            if (cipherPrivateD != 5)
            {
                MessageBox.Show("You have entered Wrong Key \n press Ok  and enter right key to proceede");
                int keyPropfD = 0;

                int b, a = 1;
                b = a / keyPropfD;

            }
            MessageBox.Show("You have entered right Key press Ok to proceede");
            //***************End Key validation******************* 
            #region



            #endregion

            for (int i = 0; i < messageLength-2; i++)
            {
                long m = Convert.ToInt64(messageStringArrayE[i]);
                //*********Dencryption***************
                /* old code for decryption
                double cipher = Math.Pow(m, db) % nb;
                */
                long cipher = mod_exp(m, db, nb);
                messageStringArrayE[i] = cipher.ToString();
                //**********Building of Cipher Text*********

                #region--[this is done because of Check Sum as in Encryption]--
                if (i == messageLength - 3)//this 2 is repalced by 1 to exclude CheckSum
                {
                    dencryptedSb.Append(messageStringArrayE[i]);
                }
                else
                {
                    dencryptedSb.Append(messageStringArrayE[i] + ",");
                }
                #endregion
            }

            string dencryptedString = dencryptedSb.ToString();

            MessageBox.Show("Congradulation:\nSystem Has Decrypted the Message Successfuly\n\nPress OK to proceede");
           
            return dencryptedString;
        }        

        public long mod_exp(long n, long e, long mod)
        {
            if (e == 1)
            {
                return (n % mod);
            }
            else
            {
                if ((e % 2) == 1)
                {
                    long temp = mod_exp(n, (e - 1) / 2, mod);
                    return ((n * temp * temp) % mod);
                }
                else
                {
                    long temp = mod_exp(n, e / 2, mod);
                    return ((temp * temp) % mod);
                }
            }
        }
    
       
    
    
    }
}

