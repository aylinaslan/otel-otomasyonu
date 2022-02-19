class Musteri
{
    private string AdSoyad;
    private ulong TCNo;
    private int OdaNo;
    public string adsoyad
    {
        get
        {
            return AdSoyad;
        }
        set
        {
            AdSoyad = value;
        }
    }
    public ulong tcno
    {
        get
        {
            return TCNo;
        }
        set
        {
            if (value.ToString().Length == 11)
                TCNo = value;
            else
                Console.WriteLine("HATA! TC Kimlik Numarası 11 Haneli Olmalıdır.");
        }
    }
    public int odano
    {
        get
        {
            return OdaNo;
        }
        set
        {
            if (value > 0 && value <= 120)
                OdaNo = value;
            else
                Console.WriteLine("HATA! Oda Numarası 1-120 Aralığında Olmalıdır. ");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Musteri m1 = new Musteri();
        m1.adsoyad = "Serdar Yılmaz";  // adsoyad özelliğinin SET metodu çalıştı.
        m1.tcno = 14548617718;         // tcno özelliğinin SET metodu çalıştı.
        m1.odano = 110;                // odano özelliğinin SET metodu çalıştı.
        // adsoyad, tcno ve odano özelliklerinin GET metodu çalıştı. 
        Console.WriteLine("Ad/Soyad:{0} - Tc No:{1} - Oda No:{2}", m1.adsoyad, m1.tcno, m1.odano);
    }
}