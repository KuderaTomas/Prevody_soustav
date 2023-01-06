using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prevody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kus1 = "";
            string kus2 = "";
            string kus3 = "";
            string kus4 = "";
            int pom = 0;
            bool proslo = true;
            string reseni1 = "";
            string reseni2 = "";
            string reseni3 = "";
            string reseni4 = "";
            long reseni01 = 0;
            long reseni02 = 0;
            long reseni03 = 0;
            long reseni04 = 0;

            if (radioButton1.Checked)
            {
                foreach (char i in maskedTextBox1.Text)
                {
                    if (i!='0'&&i!='1'&&i!=',' && i != '.' && i != ':' && proslo == true)
                    {
                        MessageBox.Show("Zadali jste špatně soustavu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        proslo = false;
                    }
                    else
                    {
                        if (i == '.' || i == ',' || i == ':')
                            pom++;
                        else if (pom == 0)
                            kus1 += i;
                        else if (pom == 1)
                            kus2 += i;
                        else if (pom == 2)
                            kus3 += i;
                        else if (pom == 3)
                            kus4 += i;
                    }
                }
                if (proslo == true)
                {
                    if (radioButton1.Checked && radioButton5.Checked)
                    {
                        reseni1 = Convert.ToInt32(kus1, 2).ToString();
                        reseni2 = Convert.ToInt32(kus2, 2).ToString();
                        reseni3 = Convert.ToInt32(kus3, 2).ToString();
                        reseni4 = Convert.ToInt32(kus4, 2).ToString();
                        MessageBox.Show(reseni1 + "." + reseni2 + "." + reseni3 + "." + reseni4, "Výsledek v decimální soustavě", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (radioButton1.Checked && radioButton6.Checked)
                    {
                        reseni1 = Convert.ToInt32(kus1, 2).ToString("X");
                        reseni2 = Convert.ToInt32(kus2, 2).ToString("X");
                        reseni3 = Convert.ToInt32(kus3, 2).ToString("X");
                        reseni4 = Convert.ToInt32(kus4, 2).ToString("X");
                        MessageBox.Show(reseni1 + ":" + reseni2 + ":" + reseni3 + ":" + reseni4, "Výsledek v hexadecimální soustavě", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (radioButton2.Checked)
            {
                foreach (char i in maskedTextBox1.Text)
                {
                    if (i!='1'&&i!='2'&&i!='3'&&i!='4'&&i!='5'&&i!='6'&&i!='7'&&i!='8'&&i!='9'&&i!=','&&i!='.'&&i!= ':' &&proslo==true)
                    {
                        MessageBox.Show("Zadali jste špatně soustavu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        proslo = false;
                    }
                    else
                    {
                        if (i == '.' || i == ',' || i == ':')
                            pom++;
                        else if (pom == 0)
                            kus1 += i;
                        else if (pom == 1)
                            kus2 += i;
                        else if (pom == 2)
                            kus3 += i;
                        else if (pom == 3)
                            kus4 += i;
                    }
                }
                if (proslo == true)
                {
                    if (radioButton2.Checked && radioButton4.Checked)
                    {
                        reseni1 = Convert.ToString(int.Parse(kus1), 2);
                        reseni2 = Convert.ToString(int.Parse(kus2), 2);
                        reseni3 = Convert.ToString(int.Parse(kus3), 2);
                        reseni4 = Convert.ToString(int.Parse(kus4), 2);
                        MessageBox.Show(reseni1 + "." + reseni2 + "." + reseni3 + "." + reseni4, "Výsledek v binární soustavě", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (radioButton2.Checked && radioButton6.Checked)
                    {
                        reseni1 = int.Parse(kus1).ToString("X");
                        reseni2 = int.Parse(kus2).ToString("X");
                        reseni3 = int.Parse(kus3).ToString("X");
                        reseni4 = int.Parse(kus4).ToString("X");
                        MessageBox.Show(reseni1 + ":" + reseni2 + ":" + reseni3 + ":" + reseni4, "Výsledek v hexadecimální soustavě", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if(radioButton3.Checked)
            {
                foreach (char i in maskedTextBox1.Text)
                {
                    if (i != '1' && i != '2' && i != '3' && i != '4' && i != '5' && i != '6' && i != '7' && i != '8' && i != '9' && i != 'A' && i != 'B' && i != 'C' && i != 'D' && i != 'E' && i != 'F' && i != 'a' && i != 'b' && i != 'c' && i != 'd' && i != 'e' && i != 'f' && i != ',' && i != '.' && i != ':' && proslo == true)
                    {
                        MessageBox.Show("Zadali jste špatně soustavu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        proslo = false;
                    }
                    else
                    {
                        if (i == '.' || i == ',' || i == ':')
                            pom++;
                        else if (pom == 0)
                            kus1 += i;
                        else if (pom == 1)
                            kus2 += i;
                        else if (pom == 2)
                            kus3 += i;
                        else if (pom == 3)
                            kus4 += i;
                    }
                }
                if (proslo == true)
                {
                    if (radioButton3.Checked && radioButton4.Checked)
                    {
                        reseni1 = Convert.ToString(Convert.ToInt64(kus1, 16), 2);
                        reseni2 = Convert.ToString(Convert.ToInt64(kus2, 16), 2);
                        reseni3 = Convert.ToString(Convert.ToInt64(kus3, 16), 2);
                        reseni4 = Convert.ToString(Convert.ToInt64(kus4, 16), 2);
                        MessageBox.Show(reseni1 + "." + reseni2 + "." + reseni3 + "." + reseni4, "Výsledek v binární soustavě", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (radioButton3.Checked && radioButton5.Checked)
                    {
                        reseni01 = Convert.ToInt64(kus1, 16);
                        reseni02 = Convert.ToInt64(kus2, 16);
                        reseni03 = Convert.ToInt64(kus3, 16);
                        reseni04 = Convert.ToInt64(kus4, 16);
                        MessageBox.Show(reseni01 + "." + reseni02 + "." + reseni03 + "." + reseni04, "Výsledek v decimální soustavě", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }  
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "00000000.00000000.00000000.00000000";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "000.000.000.000";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "aaaa:aaaa:aaaa:aaaa";
        }
    }
}
