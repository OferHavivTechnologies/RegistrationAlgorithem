/*
 * Created by SharpDevelop.
 * User: Ofer Haviv
 * Date: 09/10/2016
 * Time: 21:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SerialNumber
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            string seed = "ABYZabyz0129@.Ofer";
            lblSeed.Text = seed;
            lblResult.Text = StringLettersToHex(seed);
            lblFromFile.Text = getStringFromFile(seed);
            //combine4to3(14, 31, 30, 43);
            //new base
            //lblCalcA.Text = ConvertToBase32(270);
            ConvertToBase32();

        }
        private string StringLettersToHex(string s)
        {
            //A-Z are 0 to 25
            //a-z are 26 to 51
            //0-9 are 52 to 60
            //@.! are 61  to 63

            foreach (char c in s)
            {
                //if c between 64-90 A-Z

            }

            return convertToAscii(s, resultFormat.Hex);
        }

        private string convertToAscii(string MyString, resultFormat rf)
        {
            Encoding asc = Encoding.ASCII;
            string szResult = "";
            Byte[] encodedBytes = asc.GetBytes(MyString);

            string stringFormat = "{0:G}";
            if (rf == resultFormat.Hex) { stringFormat = "{0:x2}"; }
            foreach (Byte b in encodedBytes)
            {
                //szResult += string.Format("{0:x2}", checked((uint)System.Convert.ToUInt32(b)));
                szResult += string.Format(stringFormat, checked((uint)System.Convert.ToUInt32(b)));
                szResult += "-";
            }

            //return szResult;
            return string.Format(stringFormat, szResult);
            //return string.Format("{0,10:G}", szResult);
        }


        private string getStringFromFile(string MyString)
        {
            string[] allLines  = System.IO.File.ReadAllLines("TarnsTable.csv");
            //Translation Table

            char[] Trans = new char[64];
            
            foreach(string s in allLines)
            {
                string[] splittedString = s.Split(',');

                Trans[Convert.ToInt16(splittedString[0])-1] = splittedString[1].ToCharArray()[0];

            }

            string result="";
            foreach(char c in MyString)
            {
                result += getIndex(Trans, c).ToString();
                result += "-";

            }
            return result;

        }

        private int getIndex(char[] t,char c)
        {
            int i = 0;
            foreach(char ct in t)
            {
                if (ct == c) { return i; }
                i++;
            }
            return -1;
        }
        private int[] convertStringToAsciiDec(string s)
        {
            return null;

        }
        
        private void combine4to3(int a, int b, int c, int d)
        {


            int t1 = 3;
            int t2 = t1 << 6;

            //new base = 64
            //how to change from dec to 64

            string binA = Convert.ToString(a, 2);
            string binB = Convert.ToString(b, 2);
            string binC = Convert.ToString(c, 2);
            string binD = Convert.ToString(d, 2);

            lblA.Text = binA;
            lblB.Text = binB;
            lblC.Text = binC ;
            lblD.Text = binD ;


            string AddA="";
            string AddB="";
            string AddC="";

            //break the 4th number
            for (int i = 0; i < binD.Length; i=i+3)
            {
                AddA += binD[i];
                AddB += binD[i + 1];
                AddC += binD[i + 2];

            }

            string newA = AddA + binA;
            string newB = AddB + binB;
            string newC = AddC + binC;

            
            string calcA = Convert.ToByte(newA, 2).ToString("X");
            string calcB = Convert.ToByte(newB, 2).ToString("X");
            string calcC = Convert.ToByte(newC, 2).ToString("X");
            

            lblCalcA.Text = newA + " (" + calcA + ")";
            lblCalcB.Text = newB + " (" + calcB + ")";
            lblCalcC.Text = newC + " (" + calcC + ")";

            //now back
            string resA;
            string resB;
            string resC;
            string resD;








        }

        private string ConvertToBase32()
        {

            SN.base32 n = new SN.base32(300);

            Console.WriteLine("{0} (300) is {1}", n.Value.ToString() , n.Value32);

            SN.base32 m = new SN.base32(8710);

            Console.WriteLine("{0} 8710 is {1}", m.Value.ToString() , m.Value32);

            n.Value = 126;

            Console.WriteLine("{0} 126 is {1}", n.Value.ToString(), n.Value32);

            SN.base32 p = new SN.base32(0);

            Console.WriteLine("{0} 0 is {1}", p.Value.ToString(), p.Value32);

            SN.base32 sum = n + m;

            Console.WriteLine("sum of 126 + 8710 is {0}", sum.Value32);

            m.Value32 = "PA";
            Console.WriteLine("{0} PA is {1}", m.Value32, m.Value.ToString() );

            p.Value32 = "0023";
            Console.WriteLine("{0} 0023 is {1}", p.Value32, p.Value.ToString());

            p.Value = 0xFFF;
            Console.WriteLine("{0} 0xFFF is {1}", p.Value.ToString(), p.Value32);

            SN.base64 q = new SN.base64();

            q.Value = 0xFFFFFF;
            Console.WriteLine("{0} 0xFFFFFF is {1} in base64", q.Value.ToString(), q.Value64);

            q.Value = 0xFFFFF;
            Console.WriteLine("{0} 0xFFFFF is {1} in base64", q.Value.ToString(), q.Value64);

            q.Value = 0xFFFF;
            Console.WriteLine("{0} 0xFFFF is {1} in base64", q.Value.ToString(), q.Value64);

            q.Value = 0xFFF;
            Console.WriteLine("{0} 0xFFF is {1} in base64", q.Value.ToString(), q.Value64);

            q.Value = 0xFF;
            Console.WriteLine("{0} 0xFF is {1} in base64", q.Value.ToString(), q.Value64);

            q.Value = 150605;// 18080122092226;
            Console.WriteLine("{0} is {1} in base64", q.Value.ToString(), q.Value64);
            q.Value64 = "@gmail.com"; 
            Console.WriteLine("{0} is {1} in base64", q.Value.ToString(), q.Value64);

            try
            {
               // m.Value32 = "1q";
                n.Value32 = "1Z";

            }
            catch (Exception)
            {


            }
            



            return null;
        }
    }

    internal enum resultFormat
    {
        Hex, 
        Decimal,
    }
}
