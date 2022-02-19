public partial class Form1 : Form
{

public Form1()
{
InitializeComponent();
}

private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
{
Form2 frm2 = new Form2();
switch (comboBox1.Text)
{
case "TÜRK":
frm2.Show();
this.Hide();
break;
}
switch (comboBox1.Text )
{
case "Yabancı":
label1.Visible = true;
label2.Visible = true;
label3.Visible = true;
textBox1.Visible = true;

break;
}
}

private void Form1_Load(object sender, EventArgs e)
{
label1.Visible = false ;
label2.Visible = false ;
label3.Visible = false ;
textBox1.Visible = false ;
}

private void textBox1_TextChanged(object sender, EventArgs e)
{

int gun, tutar, para;

try
{
gun = int.Parse(textBox1.Text);
para = 100;
tutar = para * gun;
label2.Text = "Toplam Ödeyeceğiniz tutar " + tutar.ToString();
}
catch
{
MessageBox.Show("lütfen rakam giriniz");
}

}
}