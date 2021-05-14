using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SumDll;
using Multiplication;
using DivisionDll;
using SubstractionDLL;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button13.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button15.Hide();
              
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="" || textBox3.Text == "")
            {
                textBox4.Text = "NaN";
                return;
            }
            int n1, n2;
            n1 = Convert.ToInt32(textBox2.Text);
            n2 = Convert.ToInt32(textBox3.Text);
            SumDll.Class1 obj = new SumDll.Class1();
            textBox4.Text = (obj.Sum(n1,n2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                textBox4.Text = "NaN";
                return;
            }
            int n1, n2;
            n1 = Convert.ToInt32(textBox2.Text);
            n2 = Convert.ToInt32(textBox3.Text);
            Multiplication.Class1 obj = new Multiplication.Class1();
          
            textBox4.Text = (obj.multiplication(n1, n2).ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                textBox4.Text = "NaN";
                return;
            }
            double n1, n2;
            n1 = Convert.ToDouble(textBox2.Text);
            n2 = Convert.ToDouble(textBox3.Text);
            DivisionDll.Class1 obj = new DivisionDll.Class1();
            textBox4.Text = (obj.dividion(n1, n2).ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3.Hide();
            button2.Hide();
            button1.Hide();
            button13.Hide();
            button6.Show();
            button7.Show();
            button8.Show();
            button14.Show();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button15.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            button3.Show();
            button2.Show();
            button1.Show();
            button13.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            button15.Show();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button14.Hide();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Hide();
            button3.Show();
            button9.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Hide();
            button1.Show();
            button10.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Hide();
            button2.Show();
            button11.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Hide();
            button3.Hide();
            button6.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Hide();
            button1.Hide();
            button7.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Hide();
            button2.Hide();
            button8.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                textBox4.Text = "NaN";
                return;
            }
            int n1, n2;
            n1 = Convert.ToInt32(textBox2.Text);
            n2 = Convert.ToInt32(textBox3.Text);
            SubstractionDLL.Class1 obj = new SubstractionDLL.Class1();
            textBox4.Text = (obj.substraction(n1, n2).ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Hide();
            button13.Show();
            button15.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button13.Hide();
            button15.Hide();
            button14.Show();
        }
    }
}
