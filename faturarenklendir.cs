void renklendir()
        {
 
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
 
                fark = Convert.ToDateTime(dataGridView1.Rows[i].Cells["sontarih"].Value.ToString()) - Convert.ToDateTime(DateTime.Now.ToShortDateString());
                gunfark = fark.TotalDays;
                bool odeme = Convert.ToBoolean(dataGridView1.Rows[i].Cells["odendi"].Value);
                if (gunfark <= 3 && odeme==false)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (gunfark > 3 && gunfark < 7 && odeme==false)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }