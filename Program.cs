using System;

namespace CircleDrawingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int yaricap = KullaniciGirisAlma.YaricapAl();
            
            DaireCiz.Ciz(yaricap);
        }
    }
    
    public static class KullaniciGirisAlma
    {
        public static int YaricapAl()
        {
            int yaricap;
            Console.WriteLine("Daireyi çizmek için yarıçapı giriniz:");
            while (!int.TryParse(Console.ReadLine(), out yaricap) || yaricap <= 0)
            {
                Console.WriteLine("Lütfen geçerli bir pozitif tam sayı giriniz:");
            }
            return yaricap;
        }
    }
    
    public static class DaireCiz
    {
        public static void Ciz(int yaricap)
        {
            for (int y = 0; y <= 2 * yaricap; y++) 
            {
                for (int x = 0; x <= 2 * yaricap; x++) 
                {
                    int a = x - yaricap;
                    int b = y - yaricap;
                    
                    if ((a * a + b * b) <= (yaricap * yaricap) + 1)
                    {
                        Console.Write("*");  
                    }
                    else
                    {
                        Console.Write(" ");  
                    }
                }
                Console.WriteLine(); 
            }
        }
    }
}
