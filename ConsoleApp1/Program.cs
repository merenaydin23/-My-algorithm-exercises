class BinarySearch
{
    public static void Main()
    {
        int diziUzunlugu;
        do
        {
            Console.Write("Lütfen dizinin uzunluğunu girin (Pozitif bir sayı olmalıdır): ");
            diziUzunlugu = Convert.ToInt32(Console.ReadLine());
        } while (diziUzunlugu <= 0);

        int[] sayilar = new int[diziUzunlugu];
        Random rastgele = new Random();
        Console.WriteLine("-----------------------------------------------");

        // Rastgele sayılarla diziyi doldur
        for (int i = 0; i < diziUzunlugu; i++)
        {
            sayilar[i] = rastgele.Next(1300) - 450;
        }

        Console.WriteLine("Oluşturulan rastgele dizi:");
        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write(sayilar[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------\n");

        // Diziyi sıralama işlemi
        int[] siraliDizi = DiziyiSirala(sayilar);
        Console.WriteLine("Sıralanmış dizi:");
        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write(siraliDizi[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------\n");

        // Kullanıcıdan aranacak sayıyı alma
        Console.Write("Lütfen dizide aramak istediğiniz sayıyı girin: ");
        int hedefSayi = Convert.ToInt32(Console.ReadLine());
        BinarySearchAlgoritması(siraliDizi, hedefSayi);
    }

    public static int[] DiziyiSirala(int[] dizi)
    {
        int temp;
        for (int i = 0; i < dizi.Length; i++)
        {
            for (int j = i + 1; j < dizi.Length; j++)
            {
                if (dizi[j] < dizi[i])
                {
                    temp = dizi[j];
                    dizi[j] = dizi[i];
                    dizi[i] = temp;
                }
            }
        }
        return dizi;
    }

    public static void BinarySearchAlgoritması(int[] dizi, int hedef)
    {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(hedef + " sayısı dizide aranıyor...");
        Console.WriteLine("-----------------------------------------------");

        int solSinir = 0;
        int sagSinir = dizi.Length - 1;
        bool bulundu = false;

        while (solSinir <= sagSinir)
        {
            int ortaIndeks = (solSinir + sagSinir) / 2;

            if (dizi[ortaIndeks] < hedef)
            {
                solSinir = ortaIndeks + 1;
            }
            else if (dizi[ortaIndeks] > hedef)
            {
                sagSinir = ortaIndeks - 1;
            }
            else
            {
                Console.WriteLine(hedef + " sayısı dizinin " + ortaIndeks + ". indeksinde bulundu!");
                bulundu = true;
                break;
            }
        }

        if (!bulundu)
        {
            Console.WriteLine("Aradığınız sayı dizide mevcut değil.");
        }
        Console.WriteLine("-----------------------------------------------\n");
    }
}