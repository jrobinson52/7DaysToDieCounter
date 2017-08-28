using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7DTDCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {
            // catch if nothing is entered
            if (txtDay.Text == "")
                txtDay.Text = "0";

            // check every character input in txtDay to ensure it is a digit
            string var = "";
            foreach (char c in txtDay.Text)
                if (char.IsDigit(c))
                    var = var + c;

            int day = Convert.ToInt32(txtDay.Text); //define day and make input integer
            int nextDay = ((day /7) +1) * 7; //define next day and calculate next day seven
            int daysLeft = nextDay - day; //determine how many days are left till 7th day

            lblOutput.Text = nextDay.ToString(); //output next 7th day


        }
    }
}
