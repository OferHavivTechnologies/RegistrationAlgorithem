using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN
{
    public class base32
    {
        #region Local Variables...
        private long _num=0;
        private string _base32 = "";
        private char[] _hashTable = new char[32];
        private bool TABLE_WAS_READ =false;
        #endregion


        #region contractors...
        public base32(long num) 
        {
            _num = num;
            fromDecimalTo32();
        }

        public base32() : this(0)
        { }
        #endregion

        #region Methods, properties, oprators...
        public static base32 operator +(base32 a, base32 b)
        {
            return new SN.base32(a.Value + b.Value);
        }

        public long Value
        {
            get { return _num; }
            set
            {
                _num = value;
                fromDecimalTo32();
            }
        }

        public string Value32
        {
            get { return _base32; }
            set
            {
                //check validation
                if (!check32Validation(value)) { throw new Exception("extreme"); }

                //update local variable
                _base32 = value;

                //recalculate and update
                from32ToDecimal();
            }

        }
        #endregion

        #region Core...
        private void fromDecimalTo32()
        {
            long myNumber = _num;
            _base32 = "";
            //perform 32base calculate
            int digitIndex = findDigitIndex(); 
            if (digitIndex == 0)
            {
                _base32 = "0";
                return;
            }

            
            for (int d = digitIndex; d > 0; d--)
            {
                long res = myNumber / (int)(Math.Pow(32, d-1));
                //get the representing string
                _base32 += getRepresentiveChar(res);

                myNumber -= (res * (int)Math.Pow(32, d-1));
            }

        }

        private void from32ToDecimal()
        {
            _num = 0;
            int i = _base32.Length;
            foreach (char c in _base32)
            {
                _num += getChar32Value(c) * (int)(Math.Pow(32, i - 1));
                i--;

            }

        }

        private bool check32Validation(string s)
        {
            foreach (char c in s)
            {
                if (getChar32Value(c) < 0)
                {
                    return false;
                }
            }   
            return true;
        }


        private int findDigitIndex()
        {
            int i = 0;
            while (true)
            {
                if (_num > Math.Pow(32, i))
                {
                    i++;

                }
                else { return i; }

                //timeout
                if (i > 32) { throw new Exception("extreme"); }
            }
        }
        #endregion

        #region Hashing...
        private char getRepresentiveChar(long n)
        {
            if (!TABLE_WAS_READ)
            {
                readTable();
            }

            if (n > 31) { throw new Exception("extreme"); }
            return _hashTable[n];
            

        }
        private void readTable()
        {
            string[] lines = System.IO.File.ReadAllLines("countingBase.csv");
            foreach (string s in lines)
            {
                string[] splittedString = s.Split(',');
                int index = Convert.ToInt16(splittedString[0]);
                if (index < 32)
                {
                    _hashTable[index] = splittedString[1].ToCharArray()[0];
                }

            }
            TABLE_WAS_READ = true;

        }
        private int getChar32Value(char c)
        {
            if (!TABLE_WAS_READ) {readTable();}

            for (int i = 0; i < _hashTable.Length; i++)
            {
                if (c.Equals(_hashTable[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        #endregion

    }
}
