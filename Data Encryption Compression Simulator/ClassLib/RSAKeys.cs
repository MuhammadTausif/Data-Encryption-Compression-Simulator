using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Data_Encryption_Compression_Simulator.ClassLib
{
    class RSAKeys
    {
        public string GenrateKeys()
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
            int arrayCount = arr.Count - 5;
            Random rdn = new Random();
            int randomNoForPrime = rdn.Next(15, arrayCount);

            int p = Convert.ToInt32(arr[randomNoForPrime]);
            int q = Convert.ToInt32(arr[randomNoForPrime + 2]);
            int n = p * q;
            int phi = (p - 1) * (q - 1);

            //********Public Key Genration************
            int e = 3;
            Random rde = new Random();
            int randomNoForE = rde.Next(10, arrayCount);
            e = Convert.ToInt32(arr[randomNoForE]);
            if (n / e == 0)
            {
                GenrateKeys();
            }
            //********Private Key Genration***********
            int d = 2;
            int remainder = 0;
            while (remainder != 1)
            {
                d++;
                remainder = (e * d) % phi;
                if (d == phi)//thsi code is written for chek that 'd' is less then 'phi'
                {
                    remainder = 1;
                    GenrateKeys();
                }
            }


            //********Sending the public and private key********
            string sn = n.ToString();
            string se = e.ToString();
            string sd = d.ToString();

            StringBuilder sb = new StringBuilder();
            sb.Append(se + "," + sn + "." + sd + "," + sn);
            string st = sb.ToString();
            return st;
            
        }
        public int ValidatePublicKeys(string key)
        {
            string[] keys=key.Split(',');
            int e, n,aCount,kTrue;
            int eTrue=0;
            int nTrue=0;
            int aMax=0;
            int aMin=0;
            e=Convert.ToInt32( keys[0]);
            n = Convert.ToInt32(keys[1]); 
            int remainderEN =  n / e;

            #region  //*****************starts of prime number genrator******************
                 
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
            #endregion
            
            #region--[comparing e]
            aCount = arr.Count;
            for (int i = 0; i < aCount; i++)
            {
                int compE=Convert.ToInt32(arr[i]);
                if (compE == e)
                {
                    eTrue = 1;
                    i = aCount;
                }
                
            }
            #endregion

            #region--[comparing n]--
            aCount = arr.Count;
            aMax=Convert.ToInt32(arr[aCount-3]);//should be take for count again
            aMin=Convert.ToInt32(arr[aCount-5]);
                if(n>15&&n<(aMax*aMin))
                {
                    nTrue=1;
                }
            #endregion

                if (eTrue == 1 && nTrue == 1 && remainderEN != 0)
                {
                    kTrue = 1;
                }
                else
                {
                    kTrue=0;
                }
           
            return kTrue;
        }
        public string ValidatePrivateKeys()
        {
            string keys = null;
            return keys;
        }
    }
}
