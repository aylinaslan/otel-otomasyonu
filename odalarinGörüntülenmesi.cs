using System;

namespace odaların_görünümü
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;


    namespace WindowsFormsApplication1
    {
        public partial class Form1 : Form
        {
            public Form2 frm2;
            public Form3 frm3;

            public Form1()
            {
                InitializeComponent();
                frm2 = new Form2();
                frm3 = new Form3();

                frm2.frm1 = this;
                frm3.frm1 = this;

            }
            public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ace.Oledb.12.0;Data Source=data.accdb");
            public OleDbCommand kmt = new OleDbCommand();
            public OleDbDataAdapter adtr = new OleDbDataAdapter();
            public DataSet dtst = new DataSet();

            public void combo()
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Select * from bos";
                OleDbDataReader ODA;
                ODA = kmt.ExecuteReader();
                while (ODA.Read())
                {
                    comboBox1.Items.Add(ODA[0].ToString());
                }
                bag.Close();
                ODA.Dispose();
                comboBox1.Sorted = true;
            }
            public void combo2()
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Select * from dolu";
                OleDbDataReader ODA;
                ODA = kmt.ExecuteReader();
                while (ODA.Read())
                {
                    frm3.comboBox1.Items.Add(ODA[0].ToString());
                }
                bag.Close();
                ODA.Dispose();
                frm3.comboBox1.Sorted = true;

            }
            public void listele()
            {
                bag.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select * From musbil", bag);
                adtr.Fill(dtst, "musbil");
                frm3.dataView1.Table = dtst.Tables[0];
                frm3.dataGrid1.DataSource = frm3.dataView1;
                adtr.Dispose();
                bag.Close();

            }
            public void sahayaz()
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Select * from musbil";
                OleDbDataReader ODA;
                ODA = kmt.ExecuteReader();
                while (ODA.Read())
                {
                    switch (ODA[7].ToString())
                    {
                        case "ODA1":
                            {
                                frm2.button1.Text = ODA[0].ToString();
                                frm2.button1.BackColor = System.Drawing.Color.Green;
                                break;
                            }
                        case "ODA2":
                            {
                                frm2.button2.Text = ODA[0].ToString();
                                frm2.button2.BackColor = System.Drawing.Color.Green;
                                break;
                            }
                        case "ODA3":
                            {
                                frm2.button3.Text = ODA[0].ToString();
                                frm2.button3.BackColor = System.Drawing.Color.Green;
                                break;
                            }
                        case "ODA4":
                            {
                                frm2.button4.Text = ODA[0].ToString();
                                frm2.button4.BackColor = System.Drawing.Color.Green;
                                break;
                            }
                        case "ODA5":
                            {
                                frm2.button5.Text = ODA[0].ToString();
                                frm2.button5.BackColor = System.Drawing.Color.Green;
                                break;
                            }
                        case "ODA6":
                            {
                                frm2.button6.Text = ODA[0].ToString();
                                frm2.button6.BackColor = System.Drawing.Color.Green;
                                break;
                            }
                        case "ODA7":
                            {
                                frm2.button7.Text = ODA[0].ToString();
                                frm2.button7.BackColor = System.Drawing.Color.Green;
                                break;
                            }
                        case "ODA8":
                            {
                                frm2.button8.Text = ODA[0].ToString();
                                frm2.button8.BackColor = System.Drawing.Color.Green;
                                break;
                            }
                        case "ODA9":
                            {
                                frm2.button9.Text = ODA[0].ToString();
                                frm2.button9.BackColor = System.Drawing.Color.Green;
                                break;
                            }
                        case "ODA10":
                            {
                                frm2.button10.Text = ODA[0].ToString();
                                frm2.button10.BackColor = System.Drawing.Color.Green;
                                break;
                            }
                    }
                }
                bag.Close();
                ODA.Dispose();

            }
            public void sahasil()
            {

                switch (frm3.comboBox1.Text)
                {

                    case "ODA1":
                        {
                            frm2.button1.Text = "ODA1";
                            frm2.button1.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "ODA2":
                        {
                            frm2.button2.Text = "ODA2";
                            frm2.button2.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "ODA3":
                        {
                            frm2.button3.Text = "ODA3";
                            frm2.button3.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "ODA4":
                        {
                            frm2.button4.Text = "ODA4";
                            frm2.button4.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "ODA5":
                        {
                            frm2.button5.Text = "ODA5";
                            frm2.button5.BackColor = System.Drawing.Color.Red;
                            break;
                        }

                    case "ODA6":
                        {
                            frm2.button6.Text = "ODA6";
                            frm2.button6.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "ODA7":
                        {
                            frm2.button7.Text = "ODA7";
                            frm2.button7.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "ODA8":
                        {
                            frm2.button8.Text = "ODA8";
                            frm2.button8.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "ODA9":
                        {
                            frm2.button9.Text = "ODA9";
                            frm2.button9.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "ODA10":
                        {
                            frm2.button10.Text = "ODA10";
                            frm2.button10.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                }


            }


            private void Form1_Load(object sender, EventArgs e)
            {
                combo();
            }

            private void button7_Click(object sender, EventArgs e)
            {
                Close();
            }



            private void button1_Click(object sender, EventArgs e)
            {
                if (textBox3.Text != "" && textBox1.Text != "" && comboBox1.Text != "")
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "INSERT INTO musbil(TcKimlik,Ad,Soyad,CepTel,OdaTuru,Cephe,Konumu,KiralamaSuresi) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "') ";
                    kmt.ExecuteNonQuery();
                    kmt.CommandText = "INSERT INTO dolu(doluyerler) VALUES ('" + comboBox1.Text + "') ";
                    kmt.ExecuteNonQuery();
                    kmt.CommandText = "DELETE from bos WHERE bosyerler='" + comboBox1.Text + "'";
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                    comboBox1.Items.Clear();
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                    textBox2.Clear();
                    comboBox1.Text = "";
                    combo();
                    sahayaz();

                    MessageBox.Show("Odanız Ayrılmıştır!!! ");
                }
                else
                {
                    MessageBox.Show("Boş Alanları Doldurunuz!!!");
                }
            }

            private void button3_Click(object sender, EventArgs e)
            {
                frm3.Show();
                this.Hide();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                frm2.Show();
                this.Hide();
            }




        }
    }
}
