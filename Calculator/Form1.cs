using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            if ((tbxValue.Text == "0") || (isOperationPerformed))
            {
                tbxValue.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            tbxValue.Text = tbxValue.Text + button.Text;
        }

        private void operationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(tbxValue.Text);
            isOperationPerformed = true;
        }

        private void btnClearEverything_Click(object sender, EventArgs e)
        {
            tbxValue.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxValue.Text = "0";
            resultValue = 0;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    tbxValue.Text = (resultValue + Double.Parse(tbxValue.Text)).ToString();
                    break;
                case "-":
                    tbxValue.Text = (resultValue - Double.Parse(tbxValue.Text)).ToString();
                    break;
                case "/":
                    tbxValue.Text = (resultValue / Double.Parse(tbxValue.Text)).ToString();
                    break;
                case "*":
                    tbxValue.Text = (resultValue * Double.Parse(tbxValue.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
