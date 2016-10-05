using System;
using System.Collections.Generic;
using System.Text;

namespace Cipher
{
    public class CipherManager
    {
        private CipherC cc = new CipherC();

        public string Cipher(string szName, string szKey)
        {
            cc.name = szName;
            cc.key = szKey;

            cc.getCipher();

            return cc.cipher;

        }
        public bool Approve(string szCipher , string szName, string szKey)
        {
            cc.name = szName;
            cc.key = szKey;

            cc.getCipher();

            if (cc.cipher.ToLower().CompareTo(szCipher.ToLower()) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string DateCipher( string szKey)
        {
            
            cc.name = System.Net.Dns.GetHostName();
            cc.key = szKey ;

            cc.getDateCipher();

            return cc.cipher;
        }

        public int CipherDayLeft(string szCipher, string szKey)
        {
            cc.name = System.Net.Dns.GetHostName();
            cc.cipher = szCipher;

            return cc.getLeftDays();

        }


        


    }
}
