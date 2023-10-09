using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace hw2_calclulator
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private string history = "";

        public void updateHistory(string calc)
        {
            this.history += calc;
        }

        private void update(double answer)
        {
            txt_answer.Text = answer.ToString();
            string compute = txt_input.Text + " = " + answer + '\n';
            txt_input.Text = "";


            updateHistory(compute);
            this.mode = "normal";
        }
        private string mode = "normal";

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if (mode == "normal")
            {


                try
                {

                    DataTable calc = new DataTable();
                    var answer = calc.Compute(txt_input.Text, "");
                    txt_answer.Text = answer.ToString();


                    string compute = txt_input.Text + " = " + answer.ToString() + '\n';
                    txt_input.Text = "";
         

                    updateHistory(compute);
                }

                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
            else if (mode == "exp")
            {
                try
                {
                    string[] equation = txt_input.Text.Split('^');
                    double answer = Math.Pow(Double.Parse(equation[0]), Double.Parse(equation[1]));

                    update(answer);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }

            
        }

        private void btn_closePara_Click(object sender, EventArgs e)
        {
            txt_input.Text += ")";
        }

        private void btn_openPara_Click(object sender, EventArgs e)
        {
            txt_input.Text += "(";
        }


        private void btn_aSquared_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Pow(Double.Parse(txt_input.Text), 2);
                txt_answer.Text = ans.ToString();
                string compute = txt_input.Text + " ^2 = " + ans + '\n';
                txt_input.Text = "";


                updateHistory(compute);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btn_negative_Click(object sender, EventArgs e)
        {
            txt_input.Text += "-";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            bool hasDot = false;
            
            foreach (char c in txt_input.Text)
            {
                if (c == '.')
                {
                    hasDot = true;
                }
            }

            if (!hasDot)
            {
                txt_input.Text += ".";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_input.Text += "0";
        }

        private void btn_AsqRoot_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Sqrt(Double.Parse(txt_input.Text));
                txt_answer.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btn_AtoB_Click(object sender, EventArgs e)
        {
            txt_input.Text += " ^ ";
            this.mode = "exp";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_input.Clear();
            this.mode = "normal";
        }

        private void btn_hist_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.history);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_input.Text += "3";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_input.Text += "2";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_input.Text += "1";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_input.Text += "6";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_input.Text += "5";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_input.Text += "4";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_input.Text += " + ";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            txt_input.Text += " - ";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            txt_input.Text += " / ";
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            txt_input.Text += " * ";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_input.Text += "9";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_input.Text += "8";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_input.Text += "7";
        }
    }
}
