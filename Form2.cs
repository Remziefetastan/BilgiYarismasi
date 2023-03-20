using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BilgiYarismasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        SqlConnection bağlan = new SqlConnection("Data Source=DESKTOP-03D06GB\\SQLEXPRESS;Initial Catalog=BilgiYarismasi;Integrated Security=True");

        int soruno = 0;
        int doğruno = 0;
        int yanlışno = 0;

        
        private void BtnBaşla_Click(object sender, EventArgs e)
        {
            label5.Visible= false;
            BtnBaşla.Enabled = false;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;

            BtnBaşla.Text = "Sonraki";
            soruno++;
            label1.Text=soruno.ToString();
            

            if (soruno == 1)
            {
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Sorular1 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                {
                    while (oku.Read())
                    {
                        BtnA.Text = (oku["a"].ToString());
                        BtnB.Text = (oku["b"].ToString());
                        BtnC.Text = (oku["c"].ToString());
                        BtnD.Text = (oku["d"].ToString());
                        textBox1.Text = (oku["soru"].ToString());
                        label5.Text = (oku["doğru"].ToString());
                    }
                    bağlan.Close();
                }
            }

            if (soruno == 2)
            {
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Sorular2 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                {
                    while (oku.Read())
                    {
                        BtnA.Text = (oku["a"].ToString());
                        BtnB.Text = (oku["b"].ToString());
                        BtnC.Text = (oku["c"].ToString());
                        BtnD.Text = (oku["d"].ToString());
                        textBox1.Text = (oku["soru"].ToString());
                        label5.Text = (oku["doğru"].ToString());
                    }
                    bağlan.Close();
                }
            }
            if (soruno == 3)
            {
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Sorular3 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                {
                    while (oku.Read())
                    {
                        BtnA.Text = (oku["a"].ToString());
                        BtnB.Text = (oku["b"].ToString());
                        BtnC.Text = (oku["c"].ToString());
                        BtnD.Text = (oku["d"].ToString());
                        textBox1.Text = (oku["soru"].ToString());
                        label5.Text = (oku["doğru"].ToString());
                    }
                    bağlan.Close();
                }
            }
            if (soruno == 4)
            {
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Sorular4 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                {
                    while (oku.Read())
                    {
                        BtnA.Text = (oku["a"].ToString());
                        BtnB.Text = (oku["b"].ToString());
                        BtnC.Text = (oku["c"].ToString());
                        BtnD.Text = (oku["d"].ToString());
                        textBox1.Text = (oku["soru"].ToString());
                        label5.Text = (oku["doğru"].ToString());
                    }
                    bağlan.Close();
                }
            }
            if (soruno == 5)
            {
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Sorular5 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                {
                    while (oku.Read())
                    {
                        BtnA.Text = (oku["a"].ToString());
                        BtnB.Text = (oku["b"].ToString());
                        BtnC.Text = (oku["c"].ToString());
                        BtnD.Text = (oku["d"].ToString());
                        textBox1.Text = (oku["soru"].ToString());
                        label5.Text = (oku["doğru"].ToString());
                    }
                    bağlan.Close();
                }
            }
            if (soruno == 6)
            {
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Sorular6 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                {
                    while (oku.Read())
                    {
                        BtnA.Text = (oku["a"].ToString());
                        BtnB.Text = (oku["b"].ToString());
                        BtnC.Text = (oku["c"].ToString());
                        BtnD.Text = (oku["d"].ToString());
                        textBox1.Text = (oku["soru"].ToString());
                        label5.Text = (oku["doğru"].ToString());
                    }
                    bağlan.Close();
                }
            }
            if (soruno == 7)
            {
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Sorular7 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                {
                    while (oku.Read())
                    {
                        BtnA.Text = (oku["a"].ToString());
                        BtnB.Text = (oku["b"].ToString());
                        BtnC.Text = (oku["c"].ToString());
                        BtnD.Text = (oku["d"].ToString());
                        textBox1.Text = (oku["soru"].ToString());
                        label5.Text = (oku["doğru"].ToString());
                    }
                    bağlan.Close();
                }
            }
            if (soruno == 8)
            {
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Sorular8 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                {
                    while (oku.Read())
                    {
                        BtnA.Text = (oku["a"].ToString());
                        BtnB.Text = (oku["b"].ToString());
                        BtnC.Text = (oku["c"].ToString());
                        BtnD.Text = (oku["d"].ToString());
                        textBox1.Text = (oku["soru"].ToString());
                        label5.Text = (oku["doğru"].ToString());
                    }
                    bağlan.Close();
                }
            }
            if (soruno == 9)
            {
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Sorular9 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                {
                    while (oku.Read())
                    {
                        BtnA.Text = (oku["a"].ToString());
                        BtnB.Text = (oku["b"].ToString());
                        BtnC.Text = (oku["c"].ToString());
                        BtnD.Text = (oku["d"].ToString());
                        textBox1.Text = (oku["soru"].ToString());
                        label5.Text = (oku["doğru"].ToString());
                    }
                    bağlan.Close();
                }
            }
            if (soruno == 10)
            {
                BtnBaşla.Enabled= false;
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select * from Tbl_Sorular10 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                {
                    while (oku.Read())
                    {
                        BtnA.Text = (oku["a"].ToString());
                        BtnB.Text = (oku["b"].ToString());
                        BtnC.Text = (oku["c"].ToString());
                        BtnD.Text = (oku["d"].ToString());
                        textBox1.Text = (oku["soru"].ToString());
                        label5.Text = (oku["doğru"].ToString());
                        BtnBaşla.Text = "Sonuçlar";
                    }
                    bağlan.Close();
                }
            }
            if (soruno == 11) 
            {
                MessageBox.Show("Doğru: " + doğruno + "\n" + "Yanlış: " + yanlışno);
                BtnBaşla.Enabled = false;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            BtnBaşla.Enabled= true;
            BtnA.Enabled= false;
            BtnB.Enabled = false;
            BtnC.Enabled= false;
            BtnD.Enabled= false;

            if(BtnA.Text== label5.Text)
            {
                doğruno++;
                label2.Text=doğruno.ToString();
                
            }
            else
            {
                yanlışno++;
                label4.Text=yanlışno.ToString();
                
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            BtnBaşla.Enabled = true;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            if (BtnB.Text == label5.Text)
            {
                doğruno++;
                label2.Text = doğruno.ToString();
            }
            else
            {
                yanlışno++;
                label4.Text = yanlışno.ToString();
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            BtnBaşla.Enabled = true;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            if (BtnC.Text == label5.Text)
            {
                doğruno++;
                label2.Text = doğruno.ToString();
            }
            else
            {
                yanlışno++;
                label4.Text = yanlışno.ToString();
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            BtnBaşla.Enabled = true;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            if (BtnD.Text == label5.Text)
            {
                doğruno++;
                label2.Text = doğruno.ToString();
            }
            else
            {
                yanlışno++;
                label4.Text = yanlışno.ToString();
            }
        }
    }
}
