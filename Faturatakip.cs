  private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
            Listele();
            dataGridView1.Columns[0].Visible = false;
            renklendir();
            dataGridView1.Columns[1].HeaderText = "Fatura Cinsi";
            dataGridView1.Columns[2].HeaderText = "Fatura Tarihi";
            dataGridView1.Columns[3].HeaderText = "Son Ödeme Tarihi";
            dataGridView1.Columns[4].HeaderText = "Tutar";
            dataGridView1.Columns[5].HeaderText = "Ödeme Yapıldı";
 
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 cb = new OleDbCommandBuilder(da);
                 da.Update(tablo);
                 MessageBox.Show("Kayıt güncellendi");
                 renklendir();
            }
            
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
        }
    }
}