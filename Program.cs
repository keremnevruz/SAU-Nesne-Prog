namespace SAU_Nesne_Prog;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(5 + 10);
        Console.Write("1. Sayiyi giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2. sayiyi giriniz: "); 
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        int sonuc;
        if (sayi1 != 0 && sayi2 != 0)
        {
            Console.WriteLine("Sifira bolme hatasi");
        
        if (sayi1 > sayi2)
        {
            sonuc = sayi1 / sayi2;
        }
        else if (sayi1 == sayi2)
        {
            sonuc = 1;
        }
        else
        {
            sonuc = sayi2 / sayi1;
        }
        Console.WriteLine("Sonuc: " + sonuc);
    }
    }
}
