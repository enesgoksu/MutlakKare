namespace MutlakKare.MutlakKare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı girmek istiyorsunuz: ");
            int adet = int.Parse(Console.ReadLine());
            int[] sayilar = new int[adet];
            int toplam = 0;
            double toplam2 = 0;
            for (int i = 0; i < adet; i++)
            {
                Console.Write("{0}.sayıyı girin: ", i + 1);
                int sayi = int.Parse(Console.ReadLine());
                sayilar[i] = sayi;
                
                    
                if (sayilar[i] < 67)
                {
                    toplam += 67 - sayilar[i];
                    
                }
                else
                {
                    toplam2 += Math.Pow((sayilar[i] - 67), 2);

                }
            }
                    Console.WriteLine("67'den küçük olan sayıların 67'den farklarının toplamı: "+ toplam);
                    Console.WriteLine("67'den büyük olan sayıların 67'den farklarının mutlak karelerinin toplamı: "+ toplam2);
                
                

        }
    }
}