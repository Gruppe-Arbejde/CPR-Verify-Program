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
            string pattern = "^[0-10]";
            string cpr = tbCPR1.Text;

        }
    }
}
