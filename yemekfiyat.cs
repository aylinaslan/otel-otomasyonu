        class Pizzalar
        {
            public string Adi { get; set; }
            public decimal Fiyat { get; set; }
        }

        class ExtraMalzeme
        {
            public string Adi { get; set; }
            public decimal Fiyat { get; set; }
        }

        enum Boyutlar { Küçük = 1, Orta = 2, Büyük = 3, Maxi = 4 };

        List<Pizzalar> menuler = new List<Pizzalar>()
        {
            new Pizzalar {Adi = "Klasik" , Fiyat  = 14 },
            new Pizzalar {Adi = "Karışık" , Fiyat = 17 },
            new Pizzalar {Adi = "EXTRAVAGANZA" , Fiyat = 21 },
            new Pizzalar {Adi = "ITALIANO" , Fiyat = 20  },
            new Pizzalar {Adi = "TURKISH" , Fiyat = 23  },
            new Pizzalar {Adi = "TUNA" , Fiyat = 18  },
            new Pizzalar {Adi = "SEAFEED" , Fiyat = 19  },
            new Pizzalar {Adi = "KASTAMONU" , Fiyat = 20  },
            new Pizzalar {Adi = "CALYPSO" , Fiyat = 24  },
            new Pizzalar {Adi = "AKDENİZ" , Fiyat = 21  },
            new Pizzalar {Adi = "KARADENİZ" , Fiyat = 21  }
        };

        class Siparis
        {
            public Boyutlar Boyut { get; set; }
            public int Adet { get; set; }
            public decimal Tutar
            {
                get
                {
                    decimal ret = SeciliPizza.Fiyat + (int)Boyut;
                    ret += ExtraMalzemeleri.Sum(extra => extra.Fiyat);
                    ret *= Adet;
                    return ret;
                }
            }
            public Pizzalar SeciliPizza { get; set; }
            public List<ExtraMalzeme> ExtraMalzemeleri { get; set; }
            public override string ToString()
            {
                if (ExtraMalzemeleri.Count < 1)
                    return $"{SeciliPizza.Adi} Menu, {Enum.GetName(typeof(Boyutlar), Boyut)} Boy , x{Adet} Adet -> Toplam: {Tutar}";
                else
                    return $"{SeciliPizza.Adi} Menu, {Enum.GetName(typeof(Boyutlar), Boyut)} Boy , x{Adet} Adet , {string.Join(",", ExtraMalzemeleri.Select(m => m.Adi))} Malzemeli -> Toplam: {Tutar}";
            }
        }

        public Form1()
        {
            InitializeComponent();
            cmbEbatlar.DataSource = Enum.GetNames(typeof(Boyutlar));
            lstbxPizzalar.DataSource = menuler;
            lstbxPizzalar.DisplayMember = "Adi";
            lstbxPizzalar.ValueMember = "Fiyat";
        }

        public void btnHesapla_Click(object sender, EventArgs e)
        {
            Siparis siparisim = new Siparis()
            {
                SeciliPizza = (Pizzalar)lstbxPizzalar.SelectedItem,
                ExtraMalzemeleri = new List<ExtraMalzeme>(),
                Adet = Convert.ToInt32(txtAdet.Text)
            };
            grpMalzemeler.Controls.OfType<CheckBox>().Where(item => item.Checked).ToList().ForEach(item => siparisim.ExtraMalzemeleri.Add(new ExtraMalzeme()
            {
                Adi = item.Text,
                Fiyat = Convert.ToDecimal(item.Tag)
            }));
            if (cmbEbatlar.SelectedIndex < 0)
                MessageBox.Show("Boyut Seçilmedi. Lütfen Boyut Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Enum.TryParse($"{cmbEbatlar.Text}", out Boyutlar boy);
                siparisim.Boyut = boy;
                LstSiparis.Items.Add(siparisim);
                txtTutar.Text = $"{LstSiparis.Items.Cast<Siparis>().Sum(s => s.Tutar):#,##0.00}";
            }
        