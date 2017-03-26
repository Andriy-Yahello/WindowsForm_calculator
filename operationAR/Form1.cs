using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationAR
{
    public partial class Form1 : Form
    {

        Double value = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //return Convert.ToInt32(textBox1) % Convert.ToInt32(textBox2);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             //Math.Pow(Convert.ToInt32(textBox1), Convert.ToInt32(textBox2));
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //return Convert.ToInt32(textBox1) + Convert.ToInt32(textBox2);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
             //return Convert.ToInt32(textBox1) / Convert.ToInt32(textBox2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Convert.ToInt32(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button b = (Button).sender;
            if(radioButton1.Checked){
                value = Double.Parse(textBox1.Text) % Double.Parse(textBox2.Text);
                textBox3.Text = Convert.ToString(value);
            }
            else if (radioButton2.Checked)
            {
                value = Math.Pow(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text));//Math.Pow(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text))
                textBox3.Text = Convert.ToString(value);
            }
            else if (radioButton3.Checked)
            {
                value = Double.Parse(textBox1.Text) + Double.Parse(textBox2.Text);//Math.Pow(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text))
                textBox3.Text = Convert.ToString(value);
            }
            else
            {
                value = Double.Parse(textBox1.Text) / Double.Parse(textBox2.Text);//Math.Pow(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text))
                textBox3.Text = Convert.ToString(value);
            }

        }

    }
}
