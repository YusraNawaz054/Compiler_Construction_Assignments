using System;
using System.Windows.Forms;

namespace calc__special
{
    public partial class Form1 : Form
    {
        double firstNum;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void clear_click(object sender, EventArgs e)
        {
            result.Text = "";
        }

        private void btn1_click(object sender, EventArgs e)
        {
            if(result.Text == "0" && result.Text != null)
            {
                result.Text = "1";
            }
            else
            {
                result.Text = result.Text + "1";
            }
        }

        private void btn2_click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "2";
            }
            else
            {
                result.Text = result.Text + "2";
            }
        }

        private void btn3_click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "3";
            }
            else
            {
                result.Text = result.Text + "3";
            }
        }

        private void btn4_click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "4";
            }
            else
            {
                result.Text = result.Text + "4";
            }
        }

        private void btn5_click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "5";
            }
            else
            {
                result.Text = result.Text + "5";
            }
        }

        private void btn6_click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "6";
            }
            else
            {
                result.Text = result.Text + "6";
            }
        }

        private void btn7_click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "7";
            }
            else
            {
                result.Text = result.Text + "7";
            }
        }

        private void btn8_click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "8";
            }
            else
            {
                result.Text = result.Text + "8";
            }
        }

        private void btn9_click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text != null)
            {
                result.Text = "9";
            }
            else
            {
                result.Text = result.Text + "9";
            }
        }

        private void btn10_click(object sender, EventArgs e)
        {
            result.Text = result.Text + "0";
        }

        // plus
        private void plus_click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(result.Text);
            result.Text = "0";
            operation = "+";
        }

        // minus
        private void minus_click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(result.Text);
            result.Text = "0";
            operation = "-";
        }

        // multiply
        private void mul_click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(result.Text);
            result.Text = "0";
            operation = "*";
        }

        // divide
        private void divide_click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(result.Text);
            result.Text = "0";
            operation = "/";
        }

        private void equal_click(object obj, EventArgs e)
        {
            double secondNum;
            double result__result;

            secondNum = Convert.ToDouble(result.Text);

            if (operation == "+")
            {
                result__result = (firstNum + secondNum);
                result.Text = Convert.ToString(result__result);
                firstNum = result__result;
            }
            if (operation == "-")
            {
                result__result = (firstNum - secondNum);
                result.Text = Convert.ToString(result__result);
                firstNum = result__result;
            }
            if (operation == "*")
            {
                result__result = (firstNum * secondNum);
                result.Text = Convert.ToString(result__result);
                firstNum = result__result;
            }
            if (operation == "/")
            {
                if(secondNum == 0)
                {
                    result.Text = "second num cannot be 0";
                }
                else
                {
                    result__result = (firstNum / secondNum);
                    result.Text = Convert.ToString(result__result);
                    firstNum = result__result;
                }
                
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }


        private void sin_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(result.Text);
            double funcresult = Math.Sin(value);
            result.Text = funcresult.ToString();
        }

        private void cos_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(result.Text);
            double funcresult = Math.Cos(value);
            result.Text = funcresult.ToString();
        }

        private void tan_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(result.Text);
            double funcresult = Math.Tan(value);
            result.Text = funcresult.ToString();
        }

        private void log_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(result.Text);
            if (value > 0)
            {
                double funcresult = Math.Log10(value);
                result.Text = funcresult.ToString();
            }
        }
    }
}
