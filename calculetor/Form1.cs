using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculetor
{
    public partial class Form1 : Form
    {
        private TextBox txtBoxChoosen;
        public Form1()
        {
            InitializeComponent();
            txtBoxChoosen = txtValue1;
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (opretion.Text)
            {
                case "+":
                    lblResult.Text = plusNum(double.Parse(txtValue1.Text), double.Parse(txtValue2.Text));
                    break;
                case "-":
                    lblResult.Text = minusNum(double.Parse(txtValue1.Text), double.Parse(txtValue2.Text));
                    break;
                case "/":
                    lblResult.Text = divNum(double.Parse(txtValue1.Text), double.Parse(txtValue2.Text));
                    break;
                case "*":
                    lblResult.Text = mulNum(double.Parse(txtValue1.Text), double.Parse(txtValue2.Text));
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private string plusNum(double num1, double num2)
        {
            return (num1+num2).ToString();
        }
        private string mulNum(double num1, double num2)
        {
            return (num1 * num2).ToString();
        }
        private string divNum(double num1, double num2)
        {
            if (num2 != 0)
            {
                return (num1 / num2).ToString();
            }
            else
            {
                return "NaN";
            }
            
        }
        private string minusNum(double num1, double num2)
        {
            return (num1 - num2).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxChoosen = txtValue2;
        }

        private void OnOprateros_Click(object sender, EventArgs e)
        {
            opretion.Text = ((Button)sender).Text;
        }


        private void OnNumber_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Contains('.'))
                {
                if (this.txtBoxChoosen.Text.Contains('.'))
                    return;
            }
            txtBoxChoosen.Text = txtBoxChoosen.Text+((Button)sender).Text;
            
        }

        private void OnTxt_Focus(object sender, MouseEventArgs e)
        {
            txtBoxChoosen = ((TextBox)sender);
        }
    }
}
