using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork5_Calc
{
    public partial class MainForm : Form
    {
        private readonly Calculator _calc;
        public MainForm()
        {
            InitializeComponent();
            _calc = new Calculator();
        }

        private void btOne_Click(object sender, EventArgs e)
        {
            tbResult.Text += "1";
        }

        private void btTwo_Click(object sender, EventArgs e)
        {
            tbResult.Text += "2";
        }

        private void btThree_Click(object sender, EventArgs e)
        {
            tbResult.Text += "3";
        }

        private void btFour_Click(object sender, EventArgs e)
        {
            tbResult.Text += "4";
        }

        private void btFive_Click(object sender, EventArgs e)
        {
            tbResult.Text += "5";
        }

        private void btSix_Click(object sender, EventArgs e)
        {
            tbResult.Text += "6";
        }

        private void btSeven_Click(object sender, EventArgs e)
        {
            tbResult.Text += "7";
        }

        private void btEight_Click(object sender, EventArgs e)
        {
            tbResult.Text += "8";
        }

        private void btNine_Click(object sender, EventArgs e)
        {
            tbResult.Text += "9";
        }

        private void btZero_Click(object sender, EventArgs e)
        {
            tbResult.Text += "0";
        }

        private void btSeparator_Click(object sender, EventArgs e)
        {
            tbResult.Text += ",";
            btSeparator.Enabled = false;

        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            
             AddNum("+");
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
             AddNum("-");
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
             AddNum("/");
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
             AddNum("*");
        }

        private void AddNum(string typeOperation)
        {
 
            lbHistory.Text+=_calc.AddOperand(tbResult.Text);
            tbResult.Text = string.Empty;
            _calc.TypeOperation = typeOperation;
            lbHistory.Text += _calc.TypeOperation;
            btSeparator.Enabled = true;
            btPlus.Enabled = false;
            btMinus.Enabled = false;
            btDivide.Enabled = false;
            btMultiply.Enabled = false;
        }

        private void btEqually_Click(object sender, EventArgs e)
        {
            lbHistory.Text+=_calc.AddOperand(tbResult.Text);
            lbHistory.Text += "=";
            tbResult.Text = _calc.Result();
            btEqually.Enabled = false;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            _calc.Reset();
            tbResult.Text = string.Empty;
            lbHistory.Text = string.Empty;
            btSeparator.Enabled = true;
            btPlus.Enabled = true;
            btMinus.Enabled = true;
            btDivide.Enabled = true;
            btMultiply.Enabled = true;
            btEqually.Enabled = true;
        }

        private void btInverse_Click(object sender, EventArgs e)
        {
            var str = tbResult.Text;
            if (str.Length > 0 && str[0].ToString()!="-")
            {
                tbResult.Text = "-" + str;
            }
            if (str.Length > 0 && str[0].ToString() == "-")
            {
                tbResult.Text = str.Substring(1,str.Length-1);
            }

        }
    }
}
