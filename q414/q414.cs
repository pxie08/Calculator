/**************************************************
** q414.cs
** Quest 414: Gnomish Arithmetic
** Calculator
** Patrick Xie, 4/14/11
**************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace q414
{
    public partial class q414 : Form
    {
        //Global Variables
        double total1 = 0;
        double total2 = 0;
        string choice;
        bool specialOp = false;//for all special ops except pow
        bool afterOp = false;//checks if an operation was used 
                             //for button to clear textbox
        
        public q414()
        {
            InitializeComponent();
        }

        private void q414_Load(object sender, EventArgs e)
        {
            textBox.Text = "0"; //initial text in textbox
        }

        private void btnPlus_Click(object sender, EventArgs e)//comment same for +,-,*,/
        {
            //checks if is using consecutive operations
            if (choice == "-")
                total1 = total1 - double.Parse(textBox.Text);
            else if (choice == "*")
                total1 = double.Parse(textBox.Text) * total1;
            else if (choice == "/")
                total1 = total1 / double.Parse(textBox.Text);
            else if (specialOp)
                total1 = double.Parse(textBox.Text);
            else if (choice == "Pow")
            {
                total1 = Math.Pow(total1, double.Parse(textBox.Text));
                total1 = Math.Round(total1, 10);//rounds to 10 decimal places
            }
            else
                total1 = total1 + double.Parse(textBox.Text);
            textBox.Text = total1.ToString();
            textBox.Focus();//to make textbox in focus after clicked button
            choice = "+";
            afterOp = true;
            specialOp = false;
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (choice == "+")
                total1 = total1 + double.Parse(textBox.Text);
            else if (choice == "*")
                total1 = double.Parse(textBox.Text) * total1;
            else if (choice == "/")
                total1 = total1 / double.Parse(textBox.Text);
            else if (choice == "Pow")
            {
                total1 = Math.Pow(total1, double.Parse(textBox.Text));
                total1 = Math.Round(total1, 10);
            }
            else if (total1 == 0)
                total1 = double.Parse(textBox.Text);
            else if (specialOp)
                total1 = double.Parse(textBox.Text);
            else
                total1 = total1 - double.Parse(textBox.Text);
            textBox.Text = total1.ToString();
            textBox.Focus();
            choice = "-";
            afterOp = true;
            specialOp = false;
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (choice == "+")
                total1 = total1 + double.Parse(textBox.Text);
            else if (choice == "-")
                total1 = total1 - double.Parse(textBox.Text);
            else if (choice == "/")
                total1 = total1 / double.Parse(textBox.Text);
            else if (choice == "Pow")
            {
                total1 = Math.Pow(total1, double.Parse(textBox.Text));
                total1 = Math.Round(total1, 10);
            }
            else if (specialOp)
                total1 = double.Parse(textBox.Text);
            else if (total1 == 0)
                total1 = double.Parse(textBox.Text);
            else
                total1 = double.Parse(textBox.Text) * total1;
            textBox.Text = total1.ToString();
            textBox.Focus();
            choice = "*";
            afterOp = true;
            specialOp = false;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (choice == "+")
                total1 = total1 + double.Parse(textBox.Text);
            else if (choice == "-")
                total1 = total1 - double.Parse(textBox.Text);
            else if (choice == "*")
                total1 = double.Parse(textBox.Text) * total1;
            else if (choice == "Pow")
            {
                total1 = Math.Pow(total1, double.Parse(textBox.Text));
                total1 = Math.Round(total1, 10);
            }
            else if (specialOp)
                total1 = double.Parse(textBox.Text);
            else if (total1 == 0)
                total1 = double.Parse(textBox.Text);
            else
                total1 = total1 / double.Parse(textBox.Text);
            textBox.Text = total1.ToString();
            textBox.Focus();
            choice = "/";
            afterOp = true;
            specialOp = false;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {//comment same all special operations except pow
            if (choice == "Pow")//if pow is used right before Sin is used.
            {                      //does the op of Pow before sin-ing
                total1 = Math.Pow(total1, double.Parse(textBox.Text));
                total1 = Math.Round(total1, 10);
                textBox.Text = total1.ToString();
            }
            total1 = Math.Sin(double.Parse(textBox.Text));
            total1 = Math.Round(total1, 10);//makes max decimal place:10
            textBox.Text = total1.ToString() ;
            textBox.Focus();
            choice = "Sin";
            specialOp = true;
            afterOp = true;
        }
        private void btnCos_Click(object sender, EventArgs e)
        {
            if (choice == "Pow")
            {
                total1 = Math.Pow(total1, double.Parse(textBox.Text));
                total1 = Math.Round(total1, 10);
                textBox.Text = total1.ToString();
            }
            total1 = Math.Cos(double.Parse(textBox.Text));
            total1 = Math.Round(total1, 10);
            textBox.Text = total1.ToString();
            textBox.Focus();
            choice = "Cos";
            afterOp = true;
            specialOp = true;
        }
        private void btnTan_Click(object sender, EventArgs e)
        {
            if (choice == "Pow")
            {
                total1 = Math.Pow(total1, double.Parse(textBox.Text));
                total1 = Math.Round(total1, 10);
                textBox.Text = total1.ToString();
            }
            total1 = Math.Tan(double.Parse(textBox.Text));
            total1 = Math.Round(total1, 10);
            textBox.Text = total1.ToString();
            textBox.Focus();
            choice = "Tan";
            afterOp = true;
            specialOp = true;
        }
        private void btnPow_Click(object sender, EventArgs e)
        {//gets base number and will raised in equal button
            total1 = double.Parse(textBox.Text);
            textBox.Focus();
            choice = "Pow";
            afterOp = true;
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (choice == "Pow")
            {
                total1 = Math.Pow(total1, double.Parse(textBox.Text));
                total1 = Math.Round(total1, 10);
                textBox.Text = total1.ToString();
            }
            total1 = Math.Log10(double.Parse(textBox.Text));
            total1 = Math.Round(total1, 10);
            textBox.Text = total1.ToString();
            textBox.Focus();
            choice = "Log";
            afterOp = true;
            specialOp = true;
        }
        private void btnExp_Click(object sender, EventArgs e)
        {
            if (choice == "Pow")
            {
                total1 = Math.Pow(total1, double.Parse(textBox.Text));
                total1 = Math.Round(total1, 10);
                textBox.Text = total1.ToString();
            }
            total1 = Math.Exp(double.Parse(textBox.Text));
            total1 = Math.Round(total1, 10);
            textBox.Text = total1.ToString();
            textBox.Focus();
            choice = "Exp";
            afterOp = true;
            specialOp = true;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (choice)//switch to see which operation was used
            {
                case "+":
                    total2 = total1 + double.Parse(textBox.Text);
                    break;
                case "-":
                    total2 = total1 - double.Parse(textBox.Text);
                    break;
                case "*":
                    total2 = total1 * double.Parse(textBox.Text);
                    break;
                case "/":
                    total2 = total1 / double.Parse(textBox.Text);
                    break;
                case "Sin":
                    total2 = total1;
                    break;
                case "Cos":
                    total2 = total1;
                    break;
                case "Tan":
                    total2 = total1;
                    break;
                case "Pow"://power function to raise to power of whats in textbox
                    total2 = Math.Pow(total1, double.Parse(textBox.Text));
                    break;
                case "Log":
                    total2 = total1;
                    break;
                case "Exp":
                    total2 = total1;
                    break;
                default:
                    break;
            }
            total2 = Math.Round(total2, 10);
            textBox.Text = total2.ToString();
            total1 = 0;
            textBox.Focus();
            choice = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //sets everything back to nothing
            textBox.Clear();
            total1 = 0;
            total2 = 0;
            choice = "";
            afterOp = false;
            specialOp = false;
            textBox.Focus();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (afterOp)//if #button is used after an operation,
                textBox.Clear();//clears screen to input new number
            if (textBox.Text == "0")
                textBox.Text = btnZero.Text;
            else
                textBox.Text = textBox.Text + btnZero.Text;
            textBox.Focus();
            afterOp = false;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (afterOp)
                textBox.Clear();
            if (textBox.Text == "0")
                textBox.Text = btnOne.Text;
            else
                textBox.Text = textBox.Text + btnOne.Text;
            textBox.Focus();
            afterOp = false;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (afterOp)
                textBox.Clear();
            if (textBox.Text == "0")
                textBox.Text = btnTwo.Text;
            else
                textBox.Text = textBox.Text + btnTwo.Text;
            textBox.Focus();
            afterOp = false;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (afterOp)
                textBox.Clear();
            if (textBox.Text == "0")
                textBox.Text = btnThree.Text;
            else
                textBox.Text = textBox.Text + btnThree.Text;
            textBox.Focus();
            afterOp = false;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (afterOp)
                textBox.Clear();
            if (textBox.Text == "0")
                textBox.Text = btnFour.Text;
            else
                textBox.Text = textBox.Text + btnFour.Text;
            textBox.Focus();
            afterOp = false;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (afterOp)
                textBox.Clear();
            if (textBox.Text == "0")
                textBox.Text = btnFive.Text;
            else
                textBox.Text = textBox.Text + btnFive.Text;
            textBox.Focus();
            afterOp = false;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (afterOp)
                textBox.Clear();
            if (textBox.Text == "0")
                textBox.Text = btnSix.Text;
            else
                textBox.Text = textBox.Text + btnSix.Text;
            textBox.Focus();
            afterOp = false;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (afterOp)
                textBox.Clear();
            if (textBox.Text == "0")
                textBox.Text = btnSeven.Text;
            else
                textBox.Text = textBox.Text + btnSeven.Text;
            textBox.Focus();
            afterOp = false;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (afterOp)
                textBox.Clear();
            if (textBox.Text == "0")
                textBox.Text = btnEight.Text;
            else
                textBox.Text = textBox.Text + btnEight.Text;
            textBox.Focus();
            afterOp = false;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (afterOp)
                textBox.Clear();
            if (textBox.Text == "0")
                textBox.Text = btnNine.Text;
            else
                textBox.Text = textBox.Text + btnNine.Text;
            textBox.Focus();
            afterOp = false;
        }
    }
}