using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematikos_uzduotius
{
    public partial class Form1 : Form
    {
        int a, b, c;
        Random r = new Random();
        int lengvstat=0;

        public Form1()
        {
            
            InitializeComponent();
            textBox4.BackColor = Color.LightCoral;
            textBox5.BackColor = Color.LightCoral;
            textBox15.BackColor = Color.LightCoral;
            textBox10.BackColor = Color.LightCoral;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            sudetis.Visible = false;
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
            button2.Visible = false;
            button3.Visible = false;
            button7.Visible = false;
           


        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            sudetis.Visible = false;
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
            button2.Visible = false;
            button1.Visible = true;
            button3.Visible = false;
            button4.Visible = true;
            button7.Visible = false;
            button5.Visible = true;
            textBox4.Clear();
            textBox5.Clear();
            textBox15.Clear();
            textBox10.Clear();
            textBox4.BackColor = Color.LightCoral;
            textBox5.BackColor = Color.LightCoral;
            textBox15.BackColor = Color.LightCoral;
            textBox10.BackColor = Color.LightCoral;
            button6.Visible = true;
        }
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
#pragma warning disable CS8321 // Local function is declared but never used
            void exitToolStripMenuItem_Clicked(object sender, EventArgs e)
#pragma warning restore CS8321 // Local function is declared but never used
            {
                this.Close();
            }
        }

       /* private void exitToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }*/


        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
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
            button7.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
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
                // causes error this, because value are converted ToString();
                if (i == 1)
                {
                    int genRand = r.Next(10, 25);
                    textBox1.Text = genRand.ToString();
                }
                if (i == 2)
                {
                    int genRand = r.Next(10, 25);
                    textBox2.Text = genRand.ToString();
                }
                if (i == 3)
                {
                    int genRand = r.Next(10, 25);
                    textBox9.Text = genRand.ToString();
                }
                if (i == 4)
                {
                    int genRand = r.Next(10, 25);
                    textBox7.Text = genRand.ToString();
                }
                if (i == 5)
                {
                    int genRand = r.Next(10, 25);
                    textBox14.Text = genRand.ToString();
                }
                if (i == 6)
                {
                    int genRand = r.Next(10, 25);
                    textBox12.Text = genRand.ToString();
                }
                if (i == 7)
                {
                    int genRand = r.Next(10, 25);
                    textBox19.Text = genRand.ToString();
                }
                if (i == 8)
                {
                    int genRand = r.Next(10, 25);
                    textBox17.Text = genRand.ToString();
                }

            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            const string message =
        "Matematikos užduotys \nSukūrė: PMdevelopltu \nVersija: v1.0.1 \nIšleidimo data: 2021/05/08 10:12 \nProgramos atnaujinimus galite rasti: https://github.com/PMdevelopltu/mathexercises ";
            const string caption = "Apie";
            MessageBox.Show(message, caption);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form theOtherOne = new Form2();
            theOtherOne.Name = "Vidutinis lygis";
            theOtherOne.Show();
            /*  Form2 form = new Form2();
              Form2.Name
              form.Show();
              this.Visible = false;
              this.ShowInTaskbar = false;
              this.WindowState = FormWindowState.Minimized;
            */
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form theOtherOne = new Form3();
            theOtherOne.Name = "Sunkus lygis";
            theOtherOne.Show();
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
                        if (a - b == c)
                        {
                            textBox4.BackColor = Color.LightGreen;
                            lengvstat++;
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
                        if (a + b == c)
                        {
                            textBox5.BackColor = Color.LightGreen;
                            lengvstat++;
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
                        if (a - b == c)
                        {
                            textBox10.BackColor = Color.LightGreen;
                            lengvstat++;
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
                            lengvstat++;

                        }
                        if (a + b == c)
                        {
                            textBox15.BackColor = Color.LightGreen;
                            lengvstat++;
                        }
                    }
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button1.Visible = false;
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
            button7.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            button5.Visible=false;
            for (int i = 1; i <= 8; i++) {
                
                if (i == 1)
                {
                    int genRand = r.Next(10, 25);
                    textBox1.Text = genRand.ToString();
                }
                if (i == 2)
                {
                    int genRand = r.Next(10, 25);
                    textBox2.Text = genRand.ToString();
                }
                if (i == 3)
                {
                    int genRand = r.Next(10, 25);
                    textBox9.Text = genRand.ToString();
                }
                if (i == 4)
                {
                    int genRand = r.Next(10, 25); 
                    textBox7.Text = genRand.ToString();
                }
                if (i == 5)
                {
                    int genRand = r.Next(10, 25);
                    textBox14.Text = genRand.ToString();
                }
                if (i == 6)
                {
                    int genRand = r.Next(10, 25);
                    textBox12.Text = genRand.ToString();
                }
                if (i == 7) { 
                    int genRand = r.Next(10, 25);
                    textBox19.Text = genRand.ToString();
                }
                if (i == 8)
                {
                    int genRand = r.Next(10, 25);
                    textBox17.Text = genRand.ToString();
                }
              
            }
        }

        }
    

}
