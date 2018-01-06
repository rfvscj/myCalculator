using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Form_Main : Form
    {
        Stack st = new Stack();
        double num1, num2, tempresult, a;
        string tempNum = "";
        double Madd = 0;
      
        string Operator;
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
            tempNum += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
            tempNum += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
            { txtDisplay.Text = "0."; tempNum += "0."; }
            else if (!txtDisplay.Text.Contains("."))
            { txtDisplay.Text += "."; tempNum += "."; }
            }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
            tempNum += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(tempNum);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    tempresult = num1 - num2;
                    st.Push(tempresult);
                    if (Operator == "+")
                    {
                        tempresult = num2 + num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num2 * num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "x^y")
                    {
                        tempresult = Math.Pow(num2, num1);
                        st.Push(tempresult);
                    }
                    txtResult.Text = tempresult.ToString();
                }
                st.Push("-");
                txtDisplay.Text += "-";
                tempNum = "";
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
            tempNum += "0";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
            tempNum += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
            tempNum += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
            tempNum += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
            tempNum += "6";
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(tempNum);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    tempresult = num1 * num2;
                    st.Push(tempresult);
                    if (Operator == "+")
                    {
                        tempresult = num2 + num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num2 * num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "x^y")
                    {
                        tempresult = Math.Pow(num2, num1);
                        st.Push(tempresult);
                    }
                    txtResult.Text = tempresult.ToString();
                }
                st.Push("×");
                if (st.Count >= 3)
                {
                    string temp = txtDisplay.Text;
                    txtDisplay.Text = "(";
                    txtDisplay.Text += temp;
                    txtDisplay.Text += ")×";
                }
                else
                    txtDisplay.Text += "×";
                tempNum = "";
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                    st.Push(tempNum);
                if (st.Count == 1)
                {
                    tempresult =Convert.ToDouble(st.Pop());
                    st.Push(tempresult);
                    st.Clear();
                }
                else
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    tempresult = num1 / num2;
                    st.Push(tempresult);
                    if (Operator == "+")
                    {
                        tempresult = num2 + num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num2 * num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "x^y")
                    {
                        tempresult = Math.Pow(num2, num1);
                        st.Push(tempresult);
                    }
                    txtResult.Text = tempresult.ToString();
                    tempNum = tempresult.ToString();
                }
                txtResult.Text = tempresult.ToString();
                tempNum = tempresult.ToString();
                txtDisplay.Text = "Ans";
                st.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            txtResult.Text = "";
            tempNum = "";
            st.Clear();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(tempNum);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    tempresult = num1 / num2;
                    st.Push(tempresult);
                    if (Operator == "+")
                    {
                        tempresult = num2 + num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num2 * num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "x^y")
                    {
                        tempresult = Math.Pow(num2, num1);
                        st.Push(tempresult);
                    }
                    txtResult.Text = tempresult.ToString();
                }
                st.Push("÷");
                if (st.Count >= 3)
                {
                    string temp = txtDisplay.Text;
                    txtDisplay.Text = "(";
                    txtDisplay.Text += temp;
                    txtDisplay.Text += ")÷";
                }
                else
                    txtDisplay.Text += "÷";
                tempNum = "";
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                tempNum = tempNum.Substring(0, tempNum.Length - 1);
            }
            catch (Exception)
            {
                MessageBox.Show("已经为空，无法再退格了！", "错误", MessageBoxButtons.OK);
            }
        }

        private void Btn_sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                string str = tempNum;               
                double val = Convert.ToDouble(str);         
                if (val < 0)
                    MessageBox.Show("负数不可开平方根!", "错误!", MessageBoxButtons.OK);
                
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - tempNum.Length);
                txtDisplay.Text += "sqrt(" + tempNum + ")";
                val = Math.Sqrt(val);
                tempNum = val.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数字！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_Xx_Click(object sender, EventArgs e)
        {
            try
            {
                string str = tempNum;
                double val = Convert.ToDouble(str);
                if (val == 0)
                {
                    MessageBox.Show("0无倒数!", "错误", MessageBoxButtons.OK);
                }
                val = 1 / val;
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - tempNum.Length) ;
                txtDisplay.Text += "1/" + tempNum;
                tempNum = val.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数字！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            try {
                string str = tempNum;
                double val = Convert.ToDouble(str);
                val = val / 100;
                tempNum = val.ToString();
                txtDisplay.Text += "%";
                }
            catch (Exception)
            {
                MessageBox.Show("请输入数据", "错误", MessageBoxButtons.OK);
            }
            }

        private void btn_Madd_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    string str = tempNum;
                    double val = Convert.ToDouble(str);
                    Madd += val;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数据", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Madd.ToString();
            tempNum += Madd;
        }

        private void btn_MC_Click(object sender, EventArgs e)
        {
            Madd =0;
            tempNum = "";
        }

        private void btn_x_y_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(tempNum);
                if(st.Count >=3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    tempresult = Math.Pow(num2, num1);
                    st.Push(tempresult);
                    if (Operator == "+")
                    {
                        tempresult = num2 + num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num2 * num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "x^y")
                    {
                        tempresult = Math.Pow(num2, num1);
                        st.Push(tempresult);
                    }
                    tempNum = tempresult.ToString();
                }
                st.Push("x^y");
                if (st.Count >= 3)
                {
                    string temp = txtDisplay.Text;
                    txtDisplay.Text = "(";
                    txtDisplay.Text += temp;
                    txtDisplay.Text += ")^";
                }
                else
                    txtDisplay.Text += "^";
                tempNum = "";
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_0minus_Click(object sender, EventArgs e)
        {
            try
            {
                string str = tempNum;
                double val = Convert.ToDouble(str);
                val = -val;
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - tempNum.Length);
                tempNum = val.ToString();
                if (val < 0)
                    txtDisplay.Text += "(" + tempNum + ")";
                else
                    txtDisplay.Text += tempNum;
            }
            catch (Exception)
            {
                MessageBox.Show("请输入数字！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
            {
                txtDisplay.Text += "8";
                tempNum += "8";
        }

            private void btn_9_Click(object sender, EventArgs e)
            {
                txtDisplay.Text += "9";
                tempNum += "9";
        }

            private void btn_add_Click(object sender, EventArgs e)
            {
                try
                {
                    st.Push(tempNum);
                    if (st.Count >= 3)
                    {
                        num1 = Convert.ToDouble(st.Pop());
                        Operator = Convert.ToString(st.Pop());
                        num2 = Convert.ToDouble(st.Pop());
                        tempresult = num1 + num2;
                        st.Push(tempresult);
                        if (Operator == "+")
                        {
                            tempresult = num2 + num1;
                            st.Push(tempresult);
                        }
                        else if (Operator == "-")
                        {
                            tempresult = num2 - num1;
                            st.Push(tempresult);
                        }
                        else if (Operator == "×")
                        {
                            tempresult = num2 * num1;
                            st.Push(tempresult);
                        }
                        else if (Operator == "÷")
                        {
                            tempresult = num2 / num1;
                            st.Push(tempresult);
                        }
                        else if (Operator == "x^y")
                        {
                            tempresult = Math.Pow(num2, num1);
                            st.Push(tempresult);
                        }
                    txtResult.Text = tempresult.ToString();
                    }
                    st.Push("+");
                txtDisplay.Text += "+";
                    tempNum = "" ;
                }
                catch (Exception)
                {
                    MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
                }
            }
        }
    }