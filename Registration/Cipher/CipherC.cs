using System;
using System.Collections.Generic;
using System.Text;

namespace Cipher
{
    class CipherC
    {
        private String m_name = "nobody";
        private string m_key= "nokey" ;
        private string m_cipher =   "";
        private encryption en = new encryption();
        public string key
        {
            get
            {
                return m_key;
            }
            set
            {
                m_key = value;
            }
        }

        public string name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }

        public string cipher
        {
            get
            {
                return m_cipher;
            }
            set
            {
                m_cipher = value;
            }
        }

        public void getCipher()
        {

            m_cipher = en.enc (m_name, m_key);
            //throw new System.NotImplementedException();
        }

        public void getDateCipher()
        {
            cipher = "0000001D";
            //throw new System.NotImplementedException();
        }

        internal int getLeftDays()
        {
            return 5;
            //throw new Exception("The method or operation is not implemented.");
        }
    }
}
