using System;
using System.Collections.Generic;
using System.Text;

namespace Cipher
{
    class encryption
    {
        public string enc(string name, string key)
        {

            return convertToHex(name);

        }

        public string dec(string cipher, string key)
        {
            throw new Exception("123");
        }

        private string convertToHex(string MyString)
        {
            Encoding asc = Encoding.ASCII;
            string szResult="";
            Byte[] encodedBytes = asc.GetBytes(MyString);
            
            foreach (Byte b in encodedBytes) 
            {
                szResult += string.Format("{0:x2}",checked((uint)System.Convert.ToUInt32(b))); 
            }

            //return szResult;
            return string.Format("{0:x2}", szResult );
        }


    }
}
