using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN
{
    public class base64
    {
        #region Local Variables...
        private long _num=0;
        private string _base64 = "";
        private char[] _hashTable = new char[64];
        private bool TABLE_WAS_READ =false;
        #endregion


        #region contractors...
        public base64(long num) 
        {
            _num = num;
            fromDecimalTo64();
        }

        public base64() : this(0)
        { }
        #endregion

        #region Methods, properties, oprators...
        public static base64 operator +(base64 a, base64 b)
        {
            return new SN.base64(a.Value + b.Value);
        }

        public long Value
        {
            get { return _num; }
            set
            {
                _num = value;
                fromDecimalTo64();
            }
        }

        public string Value64
        {
            get { return _base64; }
            set
            {
                //check validation
                if (!check64Validation(value)) { throw new Exception("extreme"); }

                //update local variable
                _base64 = value;

                //recalculate and update
                from64ToDecimal();
            }

        }
        #endregion

        #region Core...
        private void fromDecimalTo64()
        {
            long myNumber = _num;
            _base64 = "";
            //perform 64base calculate
            int digitIndex = findDigitIndex(); 
            if (digitIndex == 0)
            {
                _base64 = "0";
                return;
            }

            
            for (int d = digitIndex; d > 0; d--)
            {
                long res = myNumber / (int)(Math.Pow(64, d-1));
                //get the representing string
                _base64 += getRepresentiveChar(res);

                myNumber -= (res * (int)Math.Pow(64, d-1));
            }

        }

        private void from64ToDecimal()
        {
            _num = 0;
            int i = _base64.Length;
            foreach (char c in _base64)
            {
                _num += getChar64Value(c) * (int)(Math.Pow(64, i - 1));
                i--;

            }

        }

        private bool check64Validation(string s)
        {
            foreach (char c in s)
            {
                if (getChar64Value(c) < 0)
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
                if (_num > Math.Pow(64, i))
                {
                    i++;

                }
                else { return i; }

                //timeout
                if (i > 64) { throw new Exception("extreme"); }
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

            if (n > 63) { throw new Exception("extreme"); }
            return _hashTable[n];
            

        }
        private void readTable()
        {
            string[] lines = System.IO.File.ReadAllLines("countingBase.csv");
            foreach (string s in lines)
            {
                string[] splittedString = s.Split(',');
                int index = Convert.ToInt16(splittedString[0]);
                if (index < 64)
                {
                    _hashTable[index] = splittedString[1].ToCharArray()[0];
                }

            }
            TABLE_WAS_READ = true;

        }
        private int getChar64Value(char c)
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
