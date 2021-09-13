using matematikos_uzduotius;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathexercises_trying_with_settings
{
    public partial class Form1 : Form

    {
        int a, b, c,d;
        int stateasy = 0, statmedium = 0, stathard = 0;
        int z = 0, f = 0, g = 0;
        Random r = new Random();
        TextWriter tsw;
        public Form1()
        {
            InitializeComponent();
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;
            //groupBox1.Hide();

        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // from menu exit
        {
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e) // about clicked opens about box
        {
            Form about = new AboutBox1();
            about.Show();

        }

        private void button1_Click(object sender, EventArgs e) //easy button
            
        {
            z++;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
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
            textBox20.Visible = true;
            textBox21.Visible = true;
            textBox22.Visible = true;
            textBox23.Visible = true;
            textBox24.Visible = true;
            textBox25.Visible = true;
            textBox26.Visible = true;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;

            textBox7.Text = "+";
            textBox8.Text = "-";
            textBox9.Text = "+";
            textBox10.Text = "-";
            textBox11.Text = "+";
            for (int i = 1; i <= 10; i++)
            {
                // causes error this, because value are converted ToString();
                if (i == 1)
                {
                    int genRand = r.Next(10, 25);
                    textBox2.Text = genRand.ToString();
                }
                if (i == 2)
                {
                    int genRand = r.Next(10, 25);
                    textBox3.Text = genRand.ToString();
                }
                if (i == 3)
                {
                    int genRand = r.Next(10, 25);
                    textBox4.Text = genRand.ToString();
                }
                if (i == 4)
                {
                    int genRand = r.Next(10, 25);
                    textBox5.Text = genRand.ToString();
                }
                if (i == 5)
                {
                    int genRand = r.Next(10, 25);
                    textBox6.Text = genRand.ToString();
                }
                if (i == 6)
                {
                    int genRand = r.Next(10, 25);
                    textBox12.Text = genRand.ToString();
                }
                if (i == 7)
                {
                    int genRand = r.Next(10, 25);
                    textBox13.Text = genRand.ToString();
                }
                if (i == 8)
                {
                    int genRand = r.Next(10, 25);
                    textBox14.Text = genRand.ToString();
                }
                if(i==9)
                {
                    int genRand = r.Next(10, 25);
                    textBox15.Text = genRand.ToString();
                }
                if (i == 10)
                {
                    int genRand = r.Next(10, 25);
                    textBox16.Text = genRand.ToString();
                }

            }
            //timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e) // medium button
        {
            f=f + 2;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
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
            textBox20.Visible = true;
            textBox21.Visible = true;
            textBox22.Visible = true;
            textBox23.Visible = true;
            textBox24.Visible = true;
            textBox25.Visible = true;
            textBox26.Visible = true;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;

            textBox7.Text = "+";
            textBox8.Text = "-";
            textBox9.Text = "/";
            textBox10.Text = "*";
            textBox11.Text = "/";
            for (int i = 1; i <= 10; i++)
            {
                // causes error this, because value are converted ToString();
                if (i == 1)
                {
                    int genRand = r.Next(10, 50);
                    textBox2.Text = genRand.ToString();
                }
                if (i == 2)
                {
                    int genRand = r.Next(10, 50);
                    textBox3.Text = genRand.ToString();
                }
                if (i == 3)
                {
                    int genRand = r.Next(10, 50);
                    textBox4.Text = genRand.ToString();
                }
                if (i == 4)
                {
                    int genRand = r.Next(10, 50);
                    textBox5.Text = genRand.ToString();
                }
                if (i == 5)
                {
                    int genRand = r.Next(10, 50);
                    textBox6.Text = genRand.ToString();
                }
                if (i == 6)
                {
                    int genRand = r.Next(10, 50);
                    textBox12.Text = genRand.ToString();
                }
                if (i == 7)
                {
                    int genRand = r.Next(10, 50);
                    textBox13.Text = genRand.ToString();
                }
                if (i == 8)
                {
                    int genRand = r.Next(10, 50);
                    textBox14.Text = genRand.ToString();
                }
                if (i == 9)
                {
                    int genRand = r.Next(10, 50);
                    textBox15.Text = genRand.ToString();
                }
                if (i == 10)
                {
                    int genRand = r.Next(10, 50);
                    textBox16.Text = genRand.ToString();
                }

            }


        }

        private void button3_Click(object sender, EventArgs e) //hard button
        {
            g = g + 3;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
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
            textBox20.Visible = true;
            textBox21.Visible = true;
            textBox22.Visible = true;
            textBox23.Visible = true;
            textBox24.Visible = true;
            textBox25.Visible = true;
            textBox26.Visible = true;
            textBox27.Visible = true;
            textBox28.Visible = true;
            textBox29.Visible = true;
            textBox30.Visible = true;
            textBox31.Visible = true;
            textBox32.Visible = true;
            textBox33.Visible = true;
            textBox34.Visible = true;
            textBox35.Visible = true;
            textBox36.Visible = true;


            textBox7.Text = "+";
            textBox8.Text = "*";
            textBox9.Text = "*";
            textBox10.Text = "-";
            textBox11.Text = "*";
            textBox27.Text = "+";
            textBox28.Text = "/";
            textBox29.Text = "+";
            textBox30.Text = "-";
            textBox31.Text = "/";
            for (int i = 1; i <= 15; i++)
            {
                // causes error this, because value are converted ToString();
                if (i == 1)
                {
                    int genRand = r.Next(50, 150);
                    textBox2.Text = genRand.ToString();
                }
                if (i == 2)
                {
                    int genRand = r.Next(50, 150);
                    textBox3.Text = genRand.ToString();
                }
                if (i == 3)
                {
                    int genRand = r.Next(50, 150);
                    textBox4.Text = genRand.ToString();
                }
                if (i == 4)
                {
                    int genRand = r.Next(50, 150);
                    textBox5.Text = genRand.ToString();
                }
                if (i == 5)
                {
                    int genRand = r.Next(50, 150);
                    textBox6.Text = genRand.ToString();
                }
                if (i == 6)
                {
                    int genRand = r.Next(50, 150);
                    textBox12.Text = genRand.ToString();
                }
                if (i == 7)
                {
                    int genRand = r.Next(50, 150);
                    textBox13.Text = genRand.ToString();
                }
                if (i == 8)
                {
                    int genRand = r.Next(50, 150);
                    textBox14.Text = genRand.ToString();
                }
                if (i == 9)
                {
                    int genRand = r.Next(50, 150);
                    textBox15.Text = genRand.ToString();
                }
                if (i == 10)
                {
                    int genRand = r.Next(50, 150);
                    textBox16.Text = genRand.ToString();
                }
                if (i == 11)
                {
                    int genRand = r.Next(50, 150);
                    textBox34.Text = genRand.ToString();
                }
                if (i == 12)
                {
                    int genRand = r.Next(50, 150);
                    textBox32.Text = genRand.ToString();
                }
                if (i == 13)
                {
                    int genRand = r.Next(50, 150);
                    textBox33.Text = genRand.ToString();
                }
                if (i == 14)
                {
                    int genRand = r.Next(50, 150);
                    textBox35.Text = genRand.ToString();
                }
                if (i == 15)
                {
                    int genRand = r.Next(50, 150);
                    textBox36.Text = genRand.ToString();
                }
            }

            //timer1.Start();


        }

        private void button4_Click(object sender, EventArgs e) //bck to main pg
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            textBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            z = 0;f = 0;g = 0;

        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e) //easy is meniu
        {
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
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
            textBox20.Visible = true;
            textBox21.Visible = true;
            textBox22.Visible = true;
            textBox23.Visible = true;
            textBox24.Visible = true;
            textBox25.Visible = true;
            textBox26.Visible = true;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;

            textBox7.Text = "+";
            textBox8.Text = "-";
            textBox9.Text = "+";
            textBox10.Text = "-";
            textBox11.Text = "+";
            for (int i = 1; i <= 10; i++)
            {
                // causes error this, because value are converted ToString();
                if (i == 1)
                {
                    int genRand = r.Next(10, 25);
                    textBox2.Text = genRand.ToString();
                }
                if (i == 2)
                {
                    int genRand = r.Next(10, 25);
                    textBox3.Text = genRand.ToString();
                }
                if (i == 3)
                {
                    int genRand = r.Next(10, 25);
                    textBox4.Text = genRand.ToString();
                }
                if (i == 4)
                {
                    int genRand = r.Next(10, 25);
                    textBox5.Text = genRand.ToString();
                }
                if (i == 5)
                {
                    int genRand = r.Next(10, 25);
                    textBox6.Text = genRand.ToString();
                }
                if (i == 6)
                {
                    int genRand = r.Next(10, 25);
                    textBox12.Text = genRand.ToString();
                }
                if (i == 7)
                {
                    int genRand = r.Next(10, 25);
                    textBox13.Text = genRand.ToString();
                }
                if (i == 8)
                {
                    int genRand = r.Next(10, 25);
                    textBox14.Text = genRand.ToString();
                }
                if (i == 9)
                {
                    int genRand = r.Next(10, 25);
                    textBox15.Text = genRand.ToString();
                }
                if (i == 10)
                {
                    int genRand = r.Next(10, 25);
                    textBox16.Text = genRand.ToString();
                }

            }

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox22.Text == "" || textBox23.Text == "" || textBox24.Text == "" || textBox25.Text == "")
            {
                const string message = "You entered not all answers. Check and try again";
                MessageBox.Show(message);
            }
            else if (z == 1)//easy check answ
            {
                for(int i=1; i<=5; i++)
                {
                    if (i == 1)
                    {
                        a = (int)Convert.ToInt64(textBox2.Text);
                        b = (int)Convert.ToInt64(textBox12.Text);
                        // c = (int)Convert.ToDouble(textBox4.Text);
                        if (textBox22.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox22.Text);

                        }
                        if (a + b == c)
                        {
                            textBox22.BackColor = Color.LightGreen;
                            stateasy++;
                        }
                        else
                        {
                            textBox22.BackColor = Color.LightCoral;
                        }
                    }
                    if (i == 2)
                    {
                        a = (int)Convert.ToInt64(textBox3.Text);
                        b = (int)Convert.ToInt64(textBox13.Text);
                        if(textBox23.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox23.Text);
                        }
                        if (a - b == c)
                        {
                            textBox23.BackColor = Color.LightGreen;
                            stateasy++;
                        }
                        else
                        {
                            textBox23.BackColor = Color.LightCoral;
                        }
                    }
                    if (i == 3)
                    {
                        a = (int)Convert.ToInt64(textBox4.Text);
                        b = (int)Convert.ToInt64(textBox14.Text);
                        if (textBox24.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox24.Text);
                        }
                        if (a + b == c)
                        {
                            textBox24.BackColor = Color.LightGreen;
                            stateasy++;
                        }
                        else
                        {
                            textBox24.BackColor = Color.LightCoral;
                        }

                    }
                    if (i == 4)
                    {
                        a = (int)Convert.ToInt64(textBox5.Text);
                        b = (int)Convert.ToInt64(textBox15.Text);
                        if (textBox25.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox25.Text);
                        }
                        if (a - b == c)
                        {
                            textBox25.BackColor = Color.LightGreen;
                            stateasy++;
                        }
                        else
                        {
                            textBox25.BackColor = Color.LightCoral;
                        }

                    }
                    if (i == 5)
                    {
                        a = (int)Convert.ToInt64(textBox6.Text);
                        b = (int)Convert.ToInt64(textBox16.Text);
                        if (textBox26.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox26.Text);
                        }
                        if (a + b == c)
                        {
                            textBox26.BackColor = Color.LightGreen;
                            stateasy++;
                        }
                        else
                        {
                            textBox26.BackColor = Color.LightCoral;
                        }

                    }

                }

            }
           else if (f == 2)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1)
                    {
                        a = (int)Convert.ToInt64(textBox2.Text);
                        b = (int)Convert.ToInt64(textBox12.Text);
                        // c = (int)Convert.ToDouble(textBox4.Text);
                        if (textBox22.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox22.Text);

                        }
                        if (a + b == c)
                        {
                            textBox22.BackColor = Color.LightGreen;
                            statmedium++;
                        }
                        else
                        {
                            textBox22.BackColor = Color.LightCoral;
                        }
                    }
                    if (i == 2)
                    {
                        a = (int)Convert.ToInt64(textBox3.Text);
                        b = (int)Convert.ToInt64(textBox13.Text);
                        if (textBox23.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox23.Text);
                        }
                        if (a - b == c)
                        {
                            textBox23.BackColor = Color.LightGreen;
                            statmedium++;
                        }
                        else
                        {
                            textBox23.BackColor = Color.LightCoral;
                        }
                    }
                    if (i == 3)
                    {
                        a = (int)Convert.ToInt64(textBox4.Text);
                        b = (int)Convert.ToInt64(textBox14.Text);
                        if (textBox24.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox24.Text);
                        }
                        if (a / b == c)
                        {
                            textBox24.BackColor = Color.LightGreen;
                            statmedium++;
                        }
                        else
                        {
                            textBox24.BackColor = Color.LightCoral;
                        }

                    }
                    if (i == 4)
                    {
                        a = (int)Convert.ToInt64(textBox5.Text);
                        b = (int)Convert.ToInt64(textBox15.Text);
                        if (textBox25.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox25.Text);
                        }
                        if (a *b == c)
                        {
                            textBox25.BackColor = Color.LightGreen;
                            statmedium++;
                        }
                        else
                        {
                            textBox25.BackColor = Color.LightCoral;
                        }

                    }
                    if (i == 5)
                    {
                        a = (int)Convert.ToInt64(textBox6.Text);
                        b = (int)Convert.ToInt64(textBox16.Text);
                        if (textBox26.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox26.Text);
                        }
                        if (a / b == c)
                        {
                            textBox26.BackColor = Color.LightGreen;
                            statmedium++;
                        }
                        else
                        {
                            textBox26.BackColor = Color.LightCoral;
                        }

                    }

                }
            }
             else if (g == 3)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1)
                    {
                        a = (int)Convert.ToInt64(textBox36.Text);
                        b = (int)Convert.ToInt64(textBox2.Text);
                        c = (int)Convert.ToDouble(textBox12.Text);
                        if (textBox22.Text != "")
                        {
                            d = (int)Convert.ToInt64(textBox22.Text);

                        }
                        if ((a/b)+c==d)
                        {
                            textBox22.BackColor = Color.LightGreen;
                            stathard++;
                        }
                        else
                        {
                            textBox22.BackColor = Color.LightCoral;
                        }
                    }
                    if (i == 2)
                    {
                        a = (int)Convert.ToInt64(textBox35.Text);
                        b = (int)Convert.ToInt64(textBox3.Text);
                        c = (int)Convert.ToInt64(textBox13.Text);
                        if (textBox23.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox23.Text);
                        }
                        if (b*c-a==d)
                        {
                            textBox23.BackColor = Color.LightGreen;
                            stathard++;
                        }
                        else
                        {
                            textBox23.BackColor = Color.LightCoral;
                        }
                    }
                    if (i == 3)
                    {
                        a = (int)Convert.ToInt64(textBox34.Text);
                        b = (int)Convert.ToInt64(textBox6.Text);
                        c = (int)Convert.ToInt64(textBox14.Text);
                        if (textBox24.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox24.Text);
                        }
                        if (b*c+a==d)
                        {
                            textBox24.BackColor = Color.LightGreen;
                            stathard++;
                        }
                        else
                        {
                            textBox24.BackColor = Color.LightCoral;
                        }

                    }
                    if (i == 4)
                    {
                        a = (int)Convert.ToInt64(textBox33.Text);
                        b = (int)Convert.ToInt64(textBox5.Text);
                        c = (int)Convert.ToInt64(textBox15.Text);
                        if (textBox25.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox25.Text);
                        }
                        if (a/b-c==d)
                        {
                            textBox25.BackColor = Color.LightGreen;
                            stathard++;
                        }
                        else
                        {
                            textBox25.BackColor = Color.LightCoral;
                        }

                    }
                    if (i == 5)
                    {
                        a = (int)Convert.ToInt64(textBox32.Text);
                        b = (int)Convert.ToInt64(textBox6.Text);
                        c = (int)Convert.ToInt64(textBox16.Text);
                        if (textBox26.Text != "")
                        {
                            c = (int)Convert.ToInt64(textBox26.Text);
                        }
                        if (b*c+a==d)
                        {
                            textBox26.BackColor = Color.LightGreen;
                            stathard++;
                        }
                        else
                        {
                            textBox26.BackColor = Color.LightCoral;
                        }

                    }

                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
            textBox1.BackColor = Color.DarkBlue;
            textBox1.ForeColor = Color.White;

            
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            textBox1.BackColor = Color.LightBlue;
            textBox1.ForeColor = Color.Gray;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString(); 
           // tsw.WriteLine(DateTime.Now.ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //groupBox1.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form stats = new Form2();
            stats.Show();
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (z == 1)
            {//clears answer boxes
                textBox22.Clear();
                textBox23.Clear();
                textBox24.Clear();
                textBox25.Clear();
                textBox26.Clear();

                for (int i = 1; i <= 10; i++)
                {
                    // causes error this, because value are converted ToString();
                    if (i == 1)
                    {
                        int genRand = r.Next(10, 25);
                        textBox2.Text = genRand.ToString();
                    }
                    if (i == 2)
                    {
                        int genRand = r.Next(10, 25);
                        textBox3.Text = genRand.ToString();
                    }
                    if (i == 3)
                    {
                        int genRand = r.Next(10, 25);
                        textBox4.Text = genRand.ToString();
                    }
                    if (i == 4)
                    {
                        int genRand = r.Next(10, 25);
                        textBox5.Text = genRand.ToString();
                    }
                    if (i == 5)
                    {
                        int genRand = r.Next(10, 25);
                        textBox6.Text = genRand.ToString();
                    }
                    if (i == 6)
                    {
                        int genRand = r.Next(10, 25);
                        textBox12.Text = genRand.ToString();
                    }
                    if (i == 7)
                    {
                        int genRand = r.Next(10, 25);
                        textBox13.Text = genRand.ToString();
                    }
                    if (i == 8)
                    {
                        int genRand = r.Next(10, 25);
                        textBox14.Text = genRand.ToString();
                    }
                    if (i == 9)
                    {
                        int genRand = r.Next(10, 25);
                        textBox15.Text = genRand.ToString();
                    }
                    if (i == 10)
                    {
                        int genRand = r.Next(10, 25);
                        textBox16.Text = genRand.ToString();
                    }

                }
            }
            if (f == 2)
            {
                textBox22.Clear();
                textBox23.Clear();
                textBox24.Clear();
                textBox25.Clear();
                textBox26.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    // causes error this, because value are converted ToString();
                    if (i == 1)
                    {
                        int genRand = r.Next(10, 50);
                        textBox2.Text = genRand.ToString();
                    }
                    if (i == 2)
                    {
                        int genRand = r.Next(10, 50);
                        textBox3.Text = genRand.ToString();
                    }
                    if (i == 3)
                    {
                        int genRand = r.Next(10, 50);
                        textBox4.Text = genRand.ToString();
                    }
                    if (i == 4)
                    {
                        int genRand = r.Next(10, 50);
                        textBox5.Text = genRand.ToString();
                    }
                    if (i == 5)
                    {
                        int genRand = r.Next(10, 50);
                        textBox6.Text = genRand.ToString();
                    }
                    if (i == 6)
                    {
                        int genRand = r.Next(10, 50);
                        textBox12.Text = genRand.ToString();
                    }
                    if (i == 7)
                    {
                        int genRand = r.Next(10, 50);
                        textBox13.Text = genRand.ToString();
                    }
                    if (i == 8)
                    {
                        int genRand = r.Next(10, 50);
                        textBox14.Text = genRand.ToString();
                    }
                    if (i == 9)
                    {
                        int genRand = r.Next(10, 50);
                        textBox15.Text = genRand.ToString();
                    }
                    if (i == 10)
                    {
                        int genRand = r.Next(10, 50);
                        textBox16.Text = genRand.ToString();
                    }

                }
            }
            if (g == 3)
            {   textBox22.Clear();
                textBox23.Clear();
                textBox24.Clear();
                textBox25.Clear();
                textBox26.Clear();
                for (int i = 1; i <= 15; i++)
                {
                    // causes error this, because value are converted ToString();
                    if (i == 1)
                    {
                        int genRand = r.Next(50, 150);
                        textBox2.Text = genRand.ToString();
                    }
                    if (i == 2)
                    {
                        int genRand = r.Next(50, 150);
                        textBox3.Text = genRand.ToString();
                    }
                    if (i == 3)
                    {
                        int genRand = r.Next(50, 150);
                        textBox4.Text = genRand.ToString();
                    }
                    if (i == 4)
                    {
                        int genRand = r.Next(50, 150);
                        textBox5.Text = genRand.ToString();
                    }
                    if (i == 5)
                    {
                        int genRand = r.Next(50, 150);
                        textBox6.Text = genRand.ToString();
                    }
                    if (i == 6)
                    {
                        int genRand = r.Next(50, 150);
                        textBox12.Text = genRand.ToString();
                    }
                    if (i == 7)
                    {
                        int genRand = r.Next(50, 150);
                        textBox13.Text = genRand.ToString();
                    }
                    if (i == 8)
                    {
                        int genRand = r.Next(50, 150);
                        textBox14.Text = genRand.ToString();
                    }
                    if (i == 9)
                    {
                        int genRand = r.Next(50, 150);
                        textBox15.Text = genRand.ToString();
                    }
                    if (i == 10)
                    {
                        int genRand = r.Next(50, 150);
                        textBox16.Text = genRand.ToString();
                    }
                    if (i == 11)
                    {
                        int genRand = r.Next(50, 150);
                        textBox32.Text = genRand.ToString();
                    }
                    if (i == 12)
                    {
                        int genRand = r.Next(50, 150);
                        textBox33.Text = genRand.ToString();
                    }
                    if (i == 13)
                    {
                        int genRand = r.Next(50, 150);
                        textBox34.Text = genRand.ToString();
                    }
                    if (i == 14)
                    {
                        int genRand = r.Next(50, 150);
                        textBox35.Text = genRand.ToString();
                    }
                    if (i == 15)
                    {
                        int genRand = r.Next(50, 150);
                        textBox36.Text = genRand.ToString();
                    }
                }
            }
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e) // medium button
        {
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
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
            textBox20.Visible = true;
            textBox21.Visible = true;
            textBox22.Visible = true;
            textBox23.Visible = true;
            textBox24.Visible = true;
            textBox25.Visible = true;
            textBox26.Visible = true;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;

            textBox7.Text = "+";
            textBox8.Text = "-";
            textBox9.Text = "/";
            textBox10.Text = "*";
            textBox11.Text = "/";
            for (int i = 1; i <= 10; i++)
            {
                // causes error this, because value are converted ToString();
                if (i == 1)
                {
                    int genRand = r.Next(10, 50);
                    textBox2.Text = genRand.ToString();
                }
                if (i == 2)
                {
                    int genRand = r.Next(10, 50);
                    textBox3.Text = genRand.ToString();
                }
                if (i == 3)
                {
                    int genRand = r.Next(10, 50);
                    textBox4.Text = genRand.ToString();
                }
                if (i == 4)
                {
                    int genRand = r.Next(10, 50);
                    textBox5.Text = genRand.ToString();
                }
                if (i == 5)
                {
                    int genRand = r.Next(10, 50);
                    textBox6.Text = genRand.ToString();
                }
                if (i == 6)
                {
                    int genRand = r.Next(10, 50);
                    textBox12.Text = genRand.ToString();
                }
                if (i == 7)
                {
                    int genRand = r.Next(10, 50);
                    textBox13.Text = genRand.ToString();
                }
                if (i == 8)
                {
                    int genRand = r.Next(10, 50);
                    textBox14.Text = genRand.ToString();
                }
                if (i == 9)
                {
                    int genRand = r.Next(10, 50);
                    textBox15.Text = genRand.ToString();
                }
                if (i == 10)
                {
                    int genRand = r.Next(10, 50);
                    textBox16.Text = genRand.ToString();
                }

            }
            //timer1.Start();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)// hard button
        {
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
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
            textBox20.Visible = true;
            textBox21.Visible = true;
            textBox22.Visible = true;
            textBox23.Visible = true;
            textBox24.Visible = true;
            textBox25.Visible = true;
            textBox26.Visible = true;
            textBox27.Visible = true;
            textBox28.Visible = true;
            textBox29.Visible = true;
            textBox30.Visible = true;
            textBox31.Visible = true;
            textBox32.Visible = true;
            textBox33.Visible = true;
            textBox34.Visible = true;
            textBox35.Visible = true;
            textBox36.Visible = true;


            textBox7.Text = "+";
            textBox8.Text = "*";
            textBox9.Text = "/";
            textBox10.Text = "-";
            textBox11.Text = "*";
            textBox27.Text = "+";
            textBox28.Text = "/";
            textBox29.Text = "+";
            textBox30.Text = "-";
            textBox31.Text = "/";

            for (int i = 1; i <= 15; i++)
            {
                // causes error this, because value are converted ToString();
                if (i == 1)
                {
                    int genRand = r.Next(50, 150);
                    textBox2.Text = genRand.ToString();
                }
                if (i == 2)
                {
                    int genRand = r.Next(50, 150);
                    textBox3.Text = genRand.ToString();
                }
                if (i == 3)
                {
                    int genRand = r.Next(50, 150);
                    textBox4.Text = genRand.ToString();
                }
                if (i == 4)
                {
                    int genRand = r.Next(50, 150);
                    textBox5.Text = genRand.ToString();
                }
                if (i == 5)
                {
                    int genRand = r.Next(50, 150);
                    textBox6.Text = genRand.ToString();
                }
                if (i == 6)
                {
                    int genRand = r.Next(50, 150);
                    textBox12.Text = genRand.ToString();
                }
                if (i == 7)
                {
                    int genRand = r.Next(50, 150);
                    textBox13.Text = genRand.ToString();
                }
                if (i == 8)
                {
                    int genRand = r.Next(50, 150);
                    textBox14.Text = genRand.ToString();
                }
                if (i == 9)
                {
                    int genRand = r.Next(50, 150);
                    textBox15.Text = genRand.ToString();
                }
                if (i == 10)
                {
                    int genRand = r.Next(50, 150);
                    textBox16.Text = genRand.ToString();
                }
                if (i == 11)
                {
                    int genRand = r.Next(50, 150);
                    textBox32.Text = genRand.ToString();
                }
                if (i == 12)
                {
                    int genRand = r.Next(50, 150);
                    textBox33.Text = genRand.ToString();
                }
                if (i == 13)
                {
                    int genRand = r.Next(50, 150);
                    textBox34.Text = genRand.ToString();
                }
                if (i == 14)
                {
                    int genRand = r.Next(50, 150);
                    textBox35.Text = genRand.ToString();
                }
                if (i == 15)
                {
                    int genRand = r.Next(50, 150);
                    textBox36.Text = genRand.ToString();
                }
            }
            //timer1.Start();
        }
    }
}
