using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double number1, number2, result;
        //
        bool trangthai = true;
        //trangthai = true khi chua kich hoat toan hang (+ -)
        String math = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if(trangthai == false)
                {
                    txt_result.Text = "";
                    trangthai = true;
                }
                String number = "1";
                txt_result.Text += number;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (trangthai == false)
            {
                txt_result.Text = "";
                trangthai = true;
            }
            String number = "2";
                txt_result.Text += number;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (trangthai == false)
            {
                txt_result.Text = "";
                trangthai = true;
            }
            String number = "3";
                txt_result.Text += number;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (trangthai == false)
            {
                txt_result.Text = "";
                trangthai = true;
            }
            String number = "5";
                txt_result.Text += number;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (trangthai == false)
            {
                txt_result.Text = "";
                trangthai = true;
            }
            String number = "6";
                txt_result.Text += number;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (trangthai == false)
            {
                txt_result.Text = "";
                trangthai = true;
            }
            String number = "7";
                txt_result.Text += number;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (trangthai == false)
            {
                txt_result.Text = "";
                trangthai = true;
            }
            String number = "8";
            txt_result.Text += number;

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (trangthai == false)
            {
                txt_result.Text = "";
                trangthai = true;
            }
            String number = "9";
                txt_result.Text += number;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(trangthai == true)
            {
                math = "+";
                txt_result.Text += " + ";
                trangthai = false;
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(trangthai == true)
            {
                math = "-";
                txt_result.Text += " - ";
                trangthai = false;
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(trangthai == true)
            {
                math = "*";
                txt_result.Text += " * ";
                trangthai = false;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(trangthai == true)
            {
                math = "/";
                txt_result.Text += " / ";
                trangthai = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            String[] kq = txt_result.Text.Split(' ');
            try
            {
                switch (kq[1])
                {
                    case "+":
                        number1 = Convert.ToDouble(kq[0]);
                        number2 = Convert.ToDouble(kq[2]);
                        result = number1 + number2;
                        txt_result.Text = result.ToString();
                        trangthai = false;
                        break;
                    case "-":
                        number1 = Convert.ToDouble(kq[0]);
                        number2 = Convert.ToDouble(kq[2]);
                        result = number1 - number2;
                        txt_result.Text = result.ToString();
                        trangthai = false;
                        break;
                    case "*":
                        number1 = Convert.ToDouble(kq[0]);
                        number2 = Convert.ToDouble(kq[2]);
                        result = number1 * number2;
                        txt_result.Text = result.ToString();
                        trangthai = false;
                        break;
                    case "/":
                        number1 = Convert.ToDouble(kq[0]);
                        number2 = Convert.ToDouble(kq[2]);
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                            txt_result.Text = result.ToString();
                            trangthai = false;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Khong The Chia 0");
                            break;
                        }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không Thể Tính");
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (trangthai == false)
            {
                txt_result.Text = "";
                trangthai = true;
            }
            String number = "4";
                txt_result.Text += number;
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (trangthai == true)
            {
                String kq = txt_result.Text;
                int lenght = txt_result.Text.Length;
                kq = kq.Remove(lenght - 1);
                txt_result.Text = kq;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String[] kq = txt_result.Text.Split(' ');
            int dodai = kq.Length;
            switch (dodai)
            {
                case 1:
                    txt_result.Text = "";
                    break;
                case 2:
                    txt_result.Text = kq[0];
                    break;
                case 3:
                    txt_result.Text = kq[0] + " " + kq[1] + " ";
                    break;
                default:
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (trangthai == false)
            {
                txt_result.Text = "";
                trangthai = true;
            }
            String number = "0";
                txt_result.Text += number;
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
