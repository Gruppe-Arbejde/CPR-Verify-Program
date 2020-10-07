using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            string[] cifre = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            string pattern = "^[0-10]";

            string cpr = tbCPR.Text;

            try
            {
                bool tst = Regex.IsMatch(cpr, pattern);

                string date = cpr.Substring(0, 2);
                string month = cpr.Substring(2, 2);
                string year = cpr.Substring(4, 2);
                if ((string.Compare(cpr.Substring(6, 1), "-") == 0) & (cpr.Length == 11) & (cpr.Trim().Length == cpr.Length))
                {
                    labelLegit.Text = $"CPR-nummer {cpr} kan være gyldig.";
                    foreach (string item in cifre)
                    {
//                        string cifre1 = (cpr.Substring(0, 1);
                    }
                }
                else
                {
                    labelLegit.Text = $"CPR-nummer {cpr} kan være ugyldig.";
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
