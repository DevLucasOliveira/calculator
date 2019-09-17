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
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;

        }

        private void Button16_Click(object sender, EventArgs e)
        {
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
            operation_pressed = false;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }
    }
}
