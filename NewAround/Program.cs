using Business.Concrete;
using newproject;

internal class Program
{
    

    private static void Main(string[] args)
    {
        NewMethod();

        static void NewMethod()
        {
            Users users = new Users();

            SelamVer(isim: "Melikşah");
            SelamVer(isim: "Uswah");

            SonucVer(sayi1: 2, sayi2: 5);

            // Diziler --Arrays //

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";
            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];

            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] city = { "Ankara", "Elazığ", "Bursa" };
            string[] city1 = { "Muğla", "Hakkari", "Şırnak" };


            foreach (string item in city)
            {
                Console.WriteLine(item);
            }


            

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(users);



}

        static void SelamVer(string isim)
        {
            Console.WriteLine("Selam Ver" + "" + isim);

        }


        static void SonucVer(int sayi1, int sayi2)
        {
            int sonuc = sayi2 + sayi1;

            Console.WriteLine(sonuc);


        }
    }
}