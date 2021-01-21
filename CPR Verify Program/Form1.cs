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

namespace CPR_Verify_Program
{
    public partial class CPRGenerator : Form
    {
        public CPRGenerator()
        {
            InitializeComponent();
        }

        private void buttonCPR_Click(object sender, EventArgs e)
        {
            int c0 = 0;
            int c1 = 0;
            int c2 = 0;
            int c3 = 0;
            int c4 = 0;
            int c5 = 0;
            int c6 = 0;
            int c7 = 0;
            int c8 = 0;
            int c9 = 0;
            string pattern = "^[0-9]";

            string cpr = tbCPR1.Text;

            if (!cpr.Contains("-"))
                tbValidCPR.Text = $"CPR-nummer {cpr} kan være ugyldigt - Bruger har tastet forkert, mangler evt. bindestreg.";
            else if (cpr.Length < 11)
                tbValidCPR.Text = $"CPR-nummer {cpr} kan være ugyldigt - Bruger har ikke skrevet et fuldt CPR-nummer (11-cifre).";
            else if (cpr.Length > 11)
                tbValidCPR.Text = $"CPR-nummer {cpr} kan være ugyldigt - Bruger har skrevet for mange cifre CPR-nummer (+11-cifre).";
            else
            {
                for (int i = 0; i < cpr.Length; i++)
                {
                    var c = cpr[i];
                    if (Regex.IsMatch(c.ToString(), pattern))
                    {
                        switch (i)
                        {
                            case 0:
                                c0 = Convert.ToInt32(Char.GetNumericValue(c)) * 4;
                                break;
                            case 1:
                                c1 = Convert.ToInt32(Char.GetNumericValue(c)) * 3;
                                break;
                            case 2:
                                c2 = Convert.ToInt32(Char.GetNumericValue(c)) * 2;
                                break;
                            case 3:
                                c3 = Convert.ToInt32(Char.GetNumericValue(c)) * 7;
                                break;
                            case 4:
                                c4 = Convert.ToInt32(Char.GetNumericValue(c)) * 6;
                                break;
                            case 5:
                                c5 = Convert.ToInt32(Char.GetNumericValue(c)) * 5;
                                break;
                            case 7:
                                c6 = Convert.ToInt32(Char.GetNumericValue(c)) * 4;
                                break;
                            case 8:
                                c7 = Convert.ToInt32(Char.GetNumericValue(c)) * 3;
                                break;
                            case 9:
                                c8 = Convert.ToInt32(Char.GetNumericValue(c)) * 2;
                                break;
                            case 10:
                                c9 = Convert.ToInt32(Char.GetNumericValue(c)) * 1;
                                break;
                            default:
                                break;
                        }
                    }
                }
                int sum = c0 + c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9;
                if (sum % 11 == 1)
                    tbValidCPR.Text = $"CPR-nummer {cpr} kan være ugyldigt.";
                else
                    tbValidCPR.Text = $"CPR-nummer {cpr} kan være gyldig.";
                float check = sum / 11;
                var personnr = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}", c0, c1, c2, c3, c4, c5, "-", c6, c7, c8, c9);
            }
        }
    }
}
