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
    public partial class Calculator : Form
    {

        double first;
        double second;
        String operation;
        Boolean click = false;

        public Calculator()
        {
            InitializeComponent();
            
        }

        //Import Class
        Class.ClsAdd obj = new Class.ClsAdd();
        Class.ClsSub obj2 = new Class.ClsSub();
        Class.ClsMpy obj3 = new Class.ClsMpy();
        Class.ClsDiv obj4 = new Class.ClsDiv();

        //Action for clean
        private void btnClear_click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
            equation.Text = "";
        }
        
        //Action for expression Result
        private void btnResult_click(object sender, EventArgs we)
        {
            second = double.Parse(tbxScreen.Text);

            double ad, sb, mp, dv;

            switch(operation){
                case "+":
                    ad = obj.Add((first), (second));
                    tbxScreen.Text = ad.ToString();
                    break;
                case "-":
                    sb = obj2.Sub((first), (second));
                    tbxScreen.Text = sb.ToString();
                    break;
                case "x":
                    mp = obj3.Mpy((first), (second));
                    tbxScreen.Text = mp.ToString();
                    break;
                case "÷":
                    if (second != 0)
                    {
                        dv = obj4.Div((first), (second));
                        tbxScreen.Text = dv.ToString();
                        break;
                    }
                    else
                    {
                        tbxScreen.Text = "ERROR";
                        break;
                    }
                default:
                    break;
            }
            click = false;
            equation.Text = "";
            equation.Text = first + " " + operation+ " " +second;
        }

        //Action for Delete one for one
        private void btnDelete_click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length > 1)
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
            else
                tbxScreen.Clear();
        }

        //Functions of the operators
        private void operatorDiv_click(object sender, EventArgs e)
        {
            click = true;
            operation = "÷";
            first = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
            equation.Text = first + " " + operation;
        }

        private void operatorMpy_click(object sender, EventArgs e)
        {
            click = true;
            operation = "x";
            first = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
            equation.Text = first + " " + operation;
        }

        private void operatorSub_click(object sender, EventArgs e)
        {
            click = true;
            operation = "-";
            first = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
            equation.Text = first + " " + operation;
        }

        private void operatorAdd_click(object sender, EventArgs e)
        {
            click = true;
            operation = "+";
            first = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
            equation.Text = first + " " + operation;
        }



        //Action butons
        private void btn0_click(object sender, EventArgs e)
        {
            if ((tbxScreen.Text == "0") || (click))
                tbxScreen.Clear();
                click = false;
            tbxScreen.Text = tbxScreen.Text + "0";
        }
        private void btn1_click(object sender, EventArgs e)
        {
            tbxScreen.Text = "";
            if ((tbxScreen.Text == "0") || (click))
                tbxScreen.Clear();
                click = false;
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btn2_click(object sender, EventArgs e)
        {
            if ((tbxScreen.Text == "0") || (click))
                tbxScreen.Clear();
            click = false;
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btn3_click(object sender, EventArgs e)
        {
            if ((tbxScreen.Text == "0") || (click))
                tbxScreen.Clear();
            click = false;
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btn4_click(object sender, EventArgs e)
        {
            if ((tbxScreen.Text == "0") || (click))
                tbxScreen.Clear();
            click = false;
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btn5_click(object sender, EventArgs e)
        {
            if ((tbxScreen.Text == "0") || (click))
                tbxScreen.Clear();
            click = false;
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btn6_click(object sender, EventArgs e)
        {
            if ((tbxScreen.Text == "0") || (click))
                tbxScreen.Clear();
            click = false;
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btn7_click(object sender, EventArgs e)
        {
            if ((tbxScreen.Text == "0") || (click))
                tbxScreen.Clear();
            click = false;
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btn8_click(object sender, EventArgs e)
        {
            if ((tbxScreen.Text == "0") || (click))
                tbxScreen.Clear();
            click = false;
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btn9_click(object sender, EventArgs e)
        {
            if ((tbxScreen.Text == "0") || (click))
                tbxScreen.Clear();
            click = false;
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btnDot_clcik(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

       
    }
}
