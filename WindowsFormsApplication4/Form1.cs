using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool mv, vrg;
        float x, y, s;
        string op;

        private void Form1_Load(object sender, EventArgs e)
        {
          vrg = true;
          mv=true;
          textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(mv==true)
            {textBox1.Text= "1";
                mv=false;
            }
            else
            {textBox1.Text=textBox1.Text +"1";}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mv = true;
                x=float.Parse(textBox1.Text);
                    op="+";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {  mv = true;
            y = float.Parse(textBox1.Text);
            if (op == "+")
                s = x + y;
            { textBox1.Text = s.ToString(); }
            if (op == "-")
                s = x - y;
            { textBox1.Text = s.ToString(); }
            if (op == "*")
                s = x * y;
            { textBox1.Text = s.ToString(); }
            if (op == "/")
            
                if ((y == 0))
                    MessageBox.Show("la division par 0 est impossible");
            
            else
                s = x / y;
            { textBox1.Text = s.ToString(); }
                
            }


            catch { }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mv == true)
            {
                textBox1.Text = "2";
                mv = false;
            }
            else
            { textBox1.Text = textBox1.Text + "2"; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mv == true)
            {
                textBox1.Text = "3";
                mv = false;
            }
            else
            { textBox1.Text = textBox1.Text + "3"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (mv == true)
            {
                textBox1.Text = "4";
                mv = false;
            }
            else
            { textBox1.Text = textBox1.Text + "4"; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (mv == true)
            {
                textBox1.Text = "5";
                mv = false;
            }
            else
            { textBox1.Text = textBox1.Text + "5"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (mv == true)
            {
                textBox1.Text = "6";
                mv = false;
            }
            else
            { textBox1.Text = textBox1.Text + "6"; }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (mv == true)
            {
                textBox1.Text = "7";
                mv = false;
            }
            else
            { textBox1.Text = textBox1.Text + "7"; }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (mv == true)
            {
                textBox1.Text = "8";
                mv = false;
            }
            else
            { textBox1.Text = textBox1.Text + "8"; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (mv == true)
            {
                textBox1.Text = "9";
                mv = false;
            }
            else
            { textBox1.Text = textBox1.Text + "9"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Enabled = false;
                textBox1.Clear();
            }
            else
            { textBox1.Enabled = true; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Enabled==false)
            { textBox1.Clear(); }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        string st;
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            st = textBox1.Text;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
             textBox1.Text=st;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (mv == true)
            {
                textBox1.Text = "0";
                mv = false;
            }
            else
            { textBox1.Text = textBox1.Text + "0"; }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            mv = true;
            x = float.Parse(textBox1.Text);
            op = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            mv = true;
            x = float.Parse(textBox1.Text);
            op = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            mv = true;
            x = float.Parse(textBox1.Text);
            op = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
           if(vrg==true)
           { textBox1.Text = textBox1.Text + ",";
           vrg = false;
           }
           
        }

       
    }
}
