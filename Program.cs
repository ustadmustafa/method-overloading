namespace method_overloading;

class Program
{
    static void Main(string[] args)
    {
        string sayi = "999";
        int outSayi;

        bool sonuc = int.TryParse(sayi,out outSayi);
        if(sonuc){
            Console.WriteLine("basarili");
            Console.WriteLine(outSayi);

        }else{
            Console.WriteLine("basarisiz");
        }

        Metotlar instance = new Metotlar();
        instance.Topla(2,3,out int toplamSonuc);
        Console.WriteLine(toplamSonuc);
    }
    
    
}

class Metotlar{
        public void Topla(int a,int b,out int toplam){
            toplam = a+b;
        }
    }

