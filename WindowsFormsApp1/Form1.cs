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
        
        string a;
        string b;
        string c;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itog.ForeColor = Color.White;
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            if ((a == b) && (b == c) && ((a == "0") || (a == "")))
            {
                itog.Text = "Введите все значения";
            }
            else
            {
                if ((b == "0") || (a == "0") ||  (c == "0") || (b == "") || (a == "") || (c == ""))
                    {
                    itog.Text = "Введите все значения";
                    if ((Convert.ToDouble(a) == 0) || (Convert.ToDouble(b) == 0) || (Convert.ToDouble(c) == 0));
                    }
                else
                {
                    if ((Convert.ToDouble(a) + Convert.ToDouble(b) <= Convert.ToDouble(c)) || (Convert.ToDouble(c) + Convert.ToDouble(b) <= Convert.ToDouble(b)) || (Convert.ToDouble(a) + Convert.ToDouble(c) <= Convert.ToDouble(b)))
                    {
                        itog.Text = "Такого треугольника не существует";
                    }
                    else
                    {
                        if (a == b && b == c)
                        {
                            itog.Text = "Треугольник равносторонний";
                        }
                        if (a == c && b != c && a != "" && b != "" && c != "")
                        {
                            itog.Text = "Треугольник равнобедренный";
                        }
                        if (a == b && b != c && a != "" && b != "" && c != "")
                        {
                            itog.Text = "Треугольник равнобедренный";
                        }
                        if (b == c && a != c && a != "" && b != "" && c != "")
                        {
                            itog.Text = "Треугольник равнобедренный";
                        }
                        if (a != b && b != c && a != "" && b != "" && c != "")
                        {
                            itog.Text = "Треугольник разносторонний";
                        }
                    }
                }
            }
                
               
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            { 
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            itog.Text = " ";

        }

        private void itog_Click(object sender, EventArgs e)
        {

        }
    }
}
