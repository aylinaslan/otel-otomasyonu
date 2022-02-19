protected void btnGonder_Click(object sender, EventArgs e)
{

if (txtAdSoyad.Text != “” & txtKonu.Text != “” & txtMail.Text != “” & txtMesaj.Text != “”)
{
string mesaj = “”;
mesaj += “<b> Kişisel site ziyaretçimden mail geldi ! </b><br/>”;
mesaj += “<b> Ad Soyadı : </b> ” + txtAdSoyad.Text + “<br/>”;
mesaj += “<b> Mail : </b> ” + txtMail.Text + “<br/>”;
mesaj += “<b> Konu : </b> ” + txtKonu.Text + “<br/>”;
mesaj += “<b> Mesaj : </b> ” + txtMesaj.Text + “<br/>”;
mesaj += “<b> Tarih : </b> ” + DateTime.Now.ToString();

MailMessage msg = new MailMessage(); // Yeni mail nesnesi oluşturduk.
msg.IsBodyHtml = true; // html kodları yazıldığında sorun çıkmaması için.
msg.To.Add(“Mesajın gideceği maili yazın”);
msg.From = new MailAddress(“mesajların gönderileceği sabit mail adresi”, “Mailde gözükecek İsim”, System.Text.Encoding.UTF8);
msg.Subject = txtKonu.Text; // mailin konusu.
msg.Body = mesaj; // mailin içeriği.

SmtpClient smtp = new SmtpClient(); // gmail için yeni smtp nesnesi oluşturduk.
smtp.EnableSsl = true; // gmail için ssl i aktif yaptık.
smtp.Credentials = new NetworkCredential(“mesajların gönderileceği sabit mail adresi”, “mail şifresi”);
smtp.Port = 587; // portu seçtik.
smtp.Host = “smtp.gmail.com”;
smtp.Send(msg);

txtAdSoyad.Text = txtKonu.Text = txtMail.Text = txtMesaj.Text = “”;
lblMesaj.Text = “Mesajınız gönderilmiştir, ilginiz için teşekkürler.”;
}
else
{
lblMesaj.Text = “Boş alan bırakmazsak daha sağlıklı iletişim kurabiliriz :)”;
}

}