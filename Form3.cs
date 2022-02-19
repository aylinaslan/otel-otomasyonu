using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;//www.gorselprogramlama.com/
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form1 frm1;
        public Form3()
        {
            InitializeComponent();
        }
        void texteyaz()
        {
            textBox6.Text = (this.BindingContext[frm1.dtst, "musbil"].Position + 1) + " / " + this.BindingContext[frm1.dtst, "musbil"].Count;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            frm1.listele();
            frm1.combo2();//www.gorselprogramlama.com/

            textBox1.DataBindings.Add("Text", frm1.dtst, "musbil.TcKimlik");
            textBox2.DataBindings.Add("Text", frm1.dtst, "musbil.Ad");
            textBox3.DataBindings.Add("Text", frm1.dtst, "musbil.Soyad");
            textBox4.DataBindings.Add("Text", frm1.dtst, "musbil.CepTel");
            textBox5.DataBindings.Add("Text", frm1.dtst, "musbil.KiralamaSuresi");
            comboBox1.DataBindings.Add("Text", frm1.dtst, "musbil.Konumu");
            comboBox2.DataBindings.Add("Text", frm1.dtst, "musbil.Cephe");
            comboBox3.DataBindings.Add("Text", frm1.dtst, "musbil.OdaTuru");
            texteyaz();

        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[frm1.dtst, "musbil"].Position = this.BindingContext[frm1.dtst, "musbilg"].Count;
            texteyaz();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[frm1.dtst, "musbil"].Position += 1;
            texteyaz();
        }//www.gorselprogramlama.com/

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[frm1.dtst, "musbil"].Position -= 1;
            texteyaz();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[frm1.dtst, "musbil"].Position = 0;
            texteyaz();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Oda çıkışı yapmak istediğinizden eminmisiniz...", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    frm1.sahasil();
                    frm1.bag.Open();
                    frm1.kmt.Connection = frm1.bag;
                    frm1.kmt.CommandText = "DELETE from musbil WHERE TcKimlik='" + textBox1.Text + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.CommandText = "INSERT INTO bos(bosyerler) VALUES ('" + comboBox1.Text + "') ";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.CommandText = "DELETE from dolu WHERE doluyerler='" + comboBox1.Text + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.Dispose();
                    frm1.bag.Close();
                    comboBox1.Items.Clear();
                    frm1.comboBox1.Items.Clear();
                    comboBox1.Text = "";
                    frm1.combo();
                    frm1.combo2();
                    frm1.dtst.Clear();
                    frm1.listele();
                    //www.gorselprogramlama.com/
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }



    }
}