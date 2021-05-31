using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace matematikos_uzduotius
{
    public partial class Form3 : Form
    {
        int a, b, c;
        Random rnd = new Random();
        Random r = new Random();
        int slygstat = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            textBox40.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            //button4.Visible = false;
            textBox4.Clear();
            textBox5.Clear();
            textBox40.Clear();
            textBox10.Clear();
            textBox4.BackColor = Color.LightCoral;
            textBox5.BackColor = Color.LightCoral;
            textBox40.BackColor = Color.LightCoral;
            textBox10.BackColor = Color.LightCoral;
            for (double i = 1; i <= 8; i++)
            {

                if (i == 1)
                {
                    double genRand = r.Next(10, 150);
                    textBox1.Text = genRand.ToString();
                }
                if (i == 2)
                {
                    double genRand = r.Next(10, 150);
                    textBox2.Text = genRand.ToString();
                }
                if (i == 3)
                {
                    double genRand = r.Next(10, 150);
                    textBox9.Text = genRand.ToString();
                }
                if (i == 4)
                {
                    double genRand = r.Next(10, 150);
                    textBox7.Text = genRand.ToString();
                }
                if (i == 5)
                {
                    double genRand = r.Next(10, 150);
                    textBox14.Text = genRand.ToString();
                }
                if (i == 6)
                {
                    double genRand = r.Next(10, 150);
                    textBox12.Text = genRand.ToString();
                }
                if (i == 7)
                {
                    double genRand = r.Next(10, 150);
                    textBox19.Text = genRand.ToString();
                }
                if (i == 8)
                {
                    double genRand = r.Next(10, 150);
                    textBox17.Text = genRand.ToString();
                }

            }
        }

        
        private void button7_Click(object sender, EventArgs e)

        {
            System.IO.Stream str = Properties.Resources.sound1;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(str);

            System.IO.Stream str1 = Properties.Resources.sound2;
            System.Media.SoundPlayer sound1 = new System.Media.SoundPlayer(str1);
            if (textBox4.Text == "" || textBox5.Text == "" || textBox10.Text == "" || textBox40.Text == "")
            {
                const string message = "You entered not all answers. Check and try again";
                MessageBox.Show(message);
            }
            else {
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
                            slygstat++;
                            sound1.Play();
                        }
                        else
                        {
                            sound.Play();
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
                            slygstat++;
                            sound1.Play();
                        }
                        else
                        {
                            sound.Play();
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
                            slygstat++;
                            sound1.Play();
                        }
                        else
                        {
                            sound.Play();
                        }
                    }
                    if (i == 4)
                    {
                        a = (int)Convert.ToInt64(textBox19.Text);
                        b = (int)Convert.ToInt64(textBox17.Text);
                        // c = (int)Convert.ToDouble(textBox4.Text);
                        if (textBox40.Text != "")
                        {
                            c = (int)Convert.ToDouble(textBox40.Text);

                        }
                        if (a / b == c)
                        {
                            textBox40.BackColor = Color.LightGreen;
                            slygstat++;
                            sound1.Play();
                        }
                        else
                        {
                            sound.Play();
                        }
                    }
                }
            }
        }

        public Form3()
        {
            InitializeComponent();
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
            textBox40.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            //button4.Visible = false;
            textBox4.Clear();
            textBox5.Clear();
            textBox40.Clear();
            textBox10.Clear();
            textBox4.BackColor = Color.LightCoral;
            textBox5.BackColor = Color.LightCoral;
            textBox40.BackColor = Color.LightCoral;
            textBox10.BackColor = Color.LightCoral;
            for (double i = 1; i <= 8; i++)
            {

                if (i == 1)
                {
                    double genRand = r.Next(10, 150);
                    textBox1.Text = genRand.ToString();
                }
                if (i == 2)
                {
                    double genRand = r.Next(10, 150);
                    textBox2.Text = genRand.ToString();
                }
                if (i == 3)
                {
                    double genRand = r.Next(10, 150);
                    textBox9.Text = genRand.ToString();
                }
                if (i == 4)
                {
                    double genRand = r.Next(10, 150);
                    textBox7.Text = genRand.ToString();
                }
                if (i == 5)
                {
                    double genRand = r.Next(10, 150);
                    textBox14.Text = genRand.ToString();
                }
                if (i == 6)
                {
                    double genRand = r.Next(10, 150);
                    textBox12.Text = genRand.ToString();
                }
                if (i == 7)
                {
                    double genRand = r.Next(10, 150);
                    textBox19.Text = genRand.ToString();
                }
                if (i == 8)
                {
                    double genRand = r.Next(10, 150);
                    textBox17.Text = genRand.ToString();
                }

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
