using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation =  "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")|| (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            equation.Text = "";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "÷":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "x":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }//end switch

           // equation.Text = value + " " + operation + " " ;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }
    }
}
