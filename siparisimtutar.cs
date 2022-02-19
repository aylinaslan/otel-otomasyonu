siparisim.TutarHesapla();
LstSiparis.Items.Add(siparisim);
txtTutar.Text = siparisim.ToplaTutar.ToString();

var toplamTutar = LstSiparis.Items.Cast<Siparis>()
                  .Sum(s => s.ToplaTutar);

txtToplamTutarLabelAdiHerneyse.Text = toplamTutar.ToString("C");