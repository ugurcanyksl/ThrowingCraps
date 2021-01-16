using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int zar1, zar2,bakiye,miktar,sonuc, toplamPara, bakiye2, bakiye1;
        string kazanan,isim;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnZarAt2.Visible = false;
            btnZarAt1.Visible = false;
            btnİsim2.Visible = false;
            txtİsim2.Visible = false;
            
        }

        private void Btnİsim1_Click(object sender, EventArgs e)
        {
            isim = txtİsim1.Text;
            lblKullanıcıAdSoyad.Text = isim;
            btnİsim1.Visible = false;
            btnİsim2.Visible = true;
            txtİsim2.Visible = true;
        }

        private void BtnOrtayaYatır1_Click(object sender, EventArgs e)
        {
            bakiye1 = Convert.ToInt32(lblBakiye1.Text);
            lblYatırılanParalar.Text = bakiye1.ToString();

           
        }

        private void BtnParaCek2_Click(object sender, EventArgs e)
        {
            bakiye = Convert.ToInt32(lblBakiye2.Text);
            miktar = Convert.ToInt32(nmrÇek2.Value);
            sonuc = bakiye - miktar;
            lblBakiye2.Text = sonuc.ToString();
        }

        private void BtnParaYatır2_Click(object sender, EventArgs e)
        {
            lblBakiye2.Text = nmrYatır2.Value.ToString();
        }

        private void BtnOrtayaYatır2_Click(object sender, EventArgs e)
        {
            bakiye2 = Convert.ToInt32(lblBakiye2.Text);
            lblYatırılanParalar.Text = (bakiye2 + bakiye1).ToString();

        }

        private void Btnİsim2_Click(object sender, EventArgs e)
        {
            isim = txtİsim2.Text;
            lblKullanıcıAdSoyad2.Text = isim;
            btnİsim1.Visible = true;
            btnZarAt1.Visible = true;
        }

        private void BtnParaYatır1_Click(object sender, EventArgs e)
        {
            lblBakiye1.Text = nmrYatır1.Value.ToString();
        }

        private void BtnParaCek1_Click(object sender, EventArgs e)
        {
            bakiye = Convert.ToInt32(lblBakiye1.Text);
            miktar = Convert.ToInt32(nmrÇek1.Value);
            sonuc = bakiye - miktar;
            lblBakiye1.Text = sonuc.ToString();
        }

        private void BtnZarAt1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            btnZarAt1.Visible = false;
            btnZarAt2.Visible = true;            
            zar1 = rnd.Next(1, 7);
            lblOyuncu1.Text = zar1.ToString();

            

        }

        private void BtnZarAt2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            zar2 = rnd.Next(1, 7);
            lblOyuncu2.Text = zar2.ToString();
            

            try
            {


                listBox1.Items.Clear();

                if (zar1<zar2)
                {
                    lblSonuc.Text = lblKullanıcıAdSoyad2.Text;
                    kazanan = "Kazanan= " + lblKullanıcıAdSoyad;
                    lblBakiye2.Text = (Convert.ToInt32(lblBakiye2.Text) + Convert.ToInt32(lblYatırılanParalar.Text)).ToString();
                    lblYatırılanParalar.Text = " ";


                }
                else if(zar1 > zar2)
                {
                    lblSonuc.Text = lblKullanıcıAdSoyad.Text;
                    kazanan = "Kazanan= " +lblKullanıcıAdSoyad2;
                    lblBakiye1.Text = (Convert.ToInt32(lblBakiye1.Text) + Convert.ToInt32(lblYatırılanParalar.Text)).ToString();
                    lblYatırılanParalar.Text = " ";
                    
                }
                else
                {
                    lblSonuc.Text = "eşit";
                }

                btnZarAt2.Visible = false;
                btnZarAt1.Visible = true;
                listBox1.Items.Add("Kazanan: " + lblSonuc.Text);

                
                
            }
                
                
            catch (Exception)
            {

                throw;
            }
        }
    }
}
