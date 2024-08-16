using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Xac nhan thoat", "Xac Nhan" , MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes)
            {
                Close();
            }
        }

        public void KetQua_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void btn1_Click(object sender, EventArgs e)
        {
            KetQua.Text += "1";
        }

        private void am_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(KetQua.Text) && !KetQua.Text.StartsWith("-"))
            {
                KetQua.Text = "-" + KetQua.Text;
            }
        }

        private void khong_Click(object sender, EventArgs e)
        {
            KetQua.Text += "0";
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            KetQua.Text = string.Empty;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            KetQua.Text = KetQua.Text + ".";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            KetQua.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            KetQua.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            KetQua.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            KetQua.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            KetQua.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            KetQua.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            KetQua.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            KetQua.Text += "9";
        }

        private void cong_Click(object sender, EventArgs e)
        {
            KetQua.Text += "+";
        }

        private void tru_Click(object sender, EventArgs e)
        {
            KetQua.Text += "-";
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            KetQua.Text += "x";
        }

        private void chia_Click(object sender, EventArgs e)
        {
            KetQua.Text += "/";
        }

        private void btnmu_Click(object sender, EventArgs e)
        {
            double.TryParse(KetQua.Text, out double number);
            double result = Math.Pow(number, 2);
            KetQua.Text = result.ToString();
            
        }

        private void btnphantram_Click(object sender, EventArgs e)
        {
            double.TryParse(KetQua.Text, out double number);
            double result = number / 100;
            KetQua.Text = result.ToString();
        }

        private void bang_Click(object sender, EventArgs e)
        {
            try
            {
                // Phân tích chuỗi trong TextBox để tìm toán tử và hai toán hạng
                string expression = KetQua.Text;

                // Kiểm tra và thực hiện phép cộng
                if (expression.Contains("+"))
                {
                    string[] parts = expression.Split('+');
                    if (double.TryParse(parts[0], out double operand1) && double.TryParse(parts[1], out double operand2))
                    {
                        double result = operand1 + operand2;
                        KetQua.Text = result.ToString();
                    }
                }
                // Kiểm tra và thực hiện phép trừ
                else if (expression.Contains("-"))
                {
                    string[] parts = expression.Split('-');
                    if (double.TryParse(parts[0], out double operand1) && double.TryParse(parts[1], out double operand2))
                    {
                        double result = operand1 - operand2;
                        KetQua.Text = result.ToString();
                    }
                }
                // Kiểm tra và thực hiện phép nhân
                else if (expression.Contains("x"))
                {
                    string[] parts = expression.Split('x');
                    if (double.TryParse(parts[0], out double operand1) && double.TryParse(parts[1], out double operand2))
                    {
                        double result = operand1 * operand2;
                        KetQua.Text = result.ToString();
                    }
                }
                // Kiểm tra và thực hiện phép chia
                else if (expression.Contains("/"))
                {
                    string[] parts = expression.Split('/');
                    if (double.TryParse(parts[0], out double operand1) && double.TryParse(parts[1], out double operand2))
                    {
                        if (operand2 != 0)
                        {
                            double result = operand1 / operand2;
                            KetQua.Text = result.ToString();
                        }
                        else
                        {
                            KetQua.Text = "Error: Division by Zero";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
