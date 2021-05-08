using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace matematikos_uzduotius
{
    public partial class Form2 : Form
    {
        int a, b, c;
        Random r = new Random();
        int vidlygstat = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //form.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            sudetis.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            //button4.Visible = false;
            textBox4.Clear();
            textBox5.Clear();
            textBox15.Clear();
            textBox10.Clear();
            textBox4.BackColor = Color.LightCoral;
            textBox5.BackColor = Color.LightCoral;
            textBox15.BackColor = Color.LightCoral;
            textBox10.BackColor = Color.LightCoral;
            for (int i = 1; i <= 8; i++)
            {

                if (i == 1)
                {
                    int genRand = r.Next(10, 100);
                    textBox1.Text = genRand.ToString();
                }
                if (i == 2)
                {
                    int genRand = r.Next(10, 100);
                    textBox2.Text = genRand.ToString();
                }
                if (i == 3)
                {
                    int genRand = r.Next(10, 100);
                    textBox9.Text = genRand.ToString();
                }
                if (i == 4)
                {
                    int genRand = r.Next(10, 100);
                    textBox7.Text = genRand.ToString();
                }
                if (i == 5)
                {
                    int genRand = r.Next(5, 30);
                    textBox14.Text = genRand.ToString();
                }
                if (i == 6)
                {
                    int genRand = r.Next(5, 30);
                    textBox12.Text = genRand.ToString();
                }
                if (i == 7)
                {
                    int genRand = r.Next(1, 50);
                    textBox19.Text = genRand.ToString();
                }
                if (i == 8)
                {
                    int genRand = r.Next(1, 50);
                    textBox17.Text = genRand.ToString();
                }

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox4.Text == "" || textBox5.Text == "" || textBox10.Text == "" || textBox15.Text == "")
            {
                const string message = " Įvedei ne visus skaičius, bandyk dar dartą";
                MessageBox.Show(message);
            }
            else
            {
                for (int i = 1; i <= 4; i++)
                {
                    if (i == 1)
                    {
                        a = (int)Convert.ToInt64(textBox1.Text);
                        b = (int)Convert.ToInt64(textBox2.Text);
                        // c = (int)Convert.ToDouble(textBox4.Text);
                        if (textBox4.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox4.Text);

                        }
                        if (a + b == c)
                        {
                            textBox4.BackColor = Color.LightGreen;
                            vidlygstat++;
                        }

                    }
                    if (i == 2)
                    {
                        // a = textBox9.ToString();
                        a = (int)Convert.ToInt64(textBox9.Text);
                        b = (int)Convert.ToInt64(textBox7.Text);
                        // c = (int)Convert.ToDouble(textBox4.Text);
                        if (textBox4.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox5.Text);

                        }
                        if (a - b == c)
                        {
                            textBox5.BackColor = Color.LightGreen;
                            vidlygstat++;
                        }
                    }
                    if (i == 3)
                    {
                        a = (int)Convert.ToInt64(textBox14.Text);
                        b = (int)Convert.ToInt64(textBox12.Text);
                        // c = (int)Convert.ToDouble(textBox4.Text);
                        if (textBox4.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox10.Text);

                        }
                        if (a * b == c)
                        {
                            textBox10.BackColor = Color.LightGreen;
                            vidlygstat++;
                        }
                    }
                    if (i == 4)
                    {
                        a = (int)Convert.ToInt64(textBox19.Text);
                        b = (int)Convert.ToInt64(textBox17.Text);
                        // c = (int)Convert.ToDouble(textBox4.Text);
                        if (textBox4.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox15.Text);

                        }
                        if (a / b == c)
                        {
                            textBox15.BackColor = Color.LightGreen;
                            vidlygstat++;
                        }
                    }
                }
            }
        }

        public Form2()
        {
                      
            InitializeComponent();
           // button1.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            sudetis.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            //button4.Visible = false;
            textBox4.Clear();
            textBox5.Clear();
            textBox15.Clear();
            textBox10.Clear();
            textBox4.BackColor = Color.LightCoral;
            textBox5.BackColor = Color.LightCoral;
            textBox15.BackColor = Color.LightCoral;
            textBox10.BackColor = Color.LightCoral;
            for (int i = 1; i <= 8; i++)
            {

                if (i == 1)
                {
                    int genRand = r.Next(10, 150);
                    textBox1.Text = genRand.ToString();
                }
                if (i == 2)
                {
                    int genRand = r.Next(10, 150);
                    textBox2.Text = genRand.ToString();
                }
                if (i == 3)
                {
                    int genRand = r.Next(10, 150);
                    textBox9.Text = genRand.ToString();
                }
                if (i == 4)
                {
                    int genRand = r.Next(10, 150);
                    textBox7.Text = genRand.ToString();
                }
                if (i == 5)
                {
                    int genRand = r.Next(5, 30);
                    textBox14.Text = genRand.ToString();
                }
                if (i == 6)
                {
                    int genRand = r.Next(5, 30);
                    textBox12.Text = genRand.ToString();
                }
                if (i == 7)
                {
                    int genRand = r.Next(10, 50);
                    textBox19.Text = genRand.ToString();
                }
                if (i == 8)
                {
                    int genRand = r.Next(10, 50);
                    textBox17.Text = genRand.ToString();
                }

            }

        }
    }
}
