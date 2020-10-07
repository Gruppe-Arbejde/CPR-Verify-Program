using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CPR_nummer_Opgave
{
    public partial class CPRGenerator : Form
    {
        public CPRGenerator()
        {
            InitializeComponent();
        }

        private void buttonCPR_Click(object sender, EventArgs e)
        {
            string pattern = "^[0-9]";

            string cpr = tbCPR1.Text; 

            string[] cprr = (string[])cpr.Clone();

            cprr.Select(N1 => 0 * 4);

            try
            {
                bool tst = Regex.IsMatch(cpr, pattern);

                string N1 = cpr.Substring(0, 1);
                string N2 = cpr.Substring(1, 1);
                string N3 = cpr.Substring(2, 1);
                string N4 = cpr.Substring(3, 1);
                string N5 = cpr.Substring(4, 1);
                string N6 = cpr.Substring(5, 1);
                string N7 = cpr.Substring(6, 1);
                string N8 = cpr.Substring(7, 1);
                string N9 = cpr.Substring(8, 1);
                string N10 = cpr.Substring(9, 1);


                //string date = cpr.Substring(0, 2);
                //string month = cpr.Substring(2, 2);
                //string year = cpr.Substring(4, 2);


                if ((string.Compare(cpr.Substring(6, 1), "-") == 0) & (cpr.Length == 11) & (cpr.Trim().Length == cpr.Length))
                {
                    tbValidCPR.Text = $"CPR-nummer {cpr} kan være gyldig.";

                    //foreach (var item in cprrr)
                    //{
                    //    tbValidCPR.Text = (item);
                    //}
                }
                else
                {
                    tbValidCPR.Text = $"CPR-nummer {cpr} kan være ugyldigt.";
                }
            }
            catch (Exception)
            {
                tbValidCPR.Text = "Du har ikke indtastet korrekt.";
            }
            Console.ReadLine();

        }
    }
}
