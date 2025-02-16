using System;

public class Solution
{
    static void Main()
    {
        int member;
        // Dizinin uzunluğunu alıyoruz ve int türüne çeviriyoruz. Uzunluğun 1 ile 100000 arasında olmasını do-while ile kontrol ediyoruz.
        do
        {
            Console.Write("Dizinin uzunluğunu giriniz: ");
            string input = Console.ReadLine();
            member = Convert.ToInt32(input);
        } while (member > 100000 || member < 1);

        // Dizi kullanıcı tarafından oluşturuluyor.
        int[] nums = new int[member];
        Console.WriteLine("Dizinin Elemanlarını Girin:");
        for (int i = 0; i < nums.Length; i++)
        {
            string input1 = Console.ReadLine();
            nums[i] = Convert.ToInt32(input1);
        }

        // Döndürme sayısını kullanıcıdan alıyoruz.
        Console.WriteLine("Lütfen döndürülme yapılacak adım sayısını giriniz: ");
        string sayı;
        int k;

        do   // 1 <= k <= 100000 aralığında olup olmadığını kontrol ediyoruz.
        {
            sayı = Console.ReadLine();
            k = Convert.ToInt32(sayı);
        } while (100000 < k || k < 1); // Hatalı koşul düzeltildi (10000 yerine 100000)

        // Dizi ve döndürme sayısını "Rotate" fonksiyonuna gönderiyoruz.
        Rotate(nums, k);
    }

    static void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        k = k % n; // Döndürme sayısını dizi uzunluğuna göre normalize ediyoruz.

        // Eğer döndürme sayısı "k" sıfırsa, dizi değişmeden kalır.
        if (k == 0)
        {
            Console.WriteLine("Döndürme Sonucunda Dizi Şu Şekildedir: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
        else
        {
            // Aynı uzunlukta bir nums1 dizisi oluşturup, k kadar ötelenmiş halini atayacağız.
            int[] nums1 = new int[n];
            // Dizi döndürme işlemi
            for (int i = 0; i < n; i++)
            {
                nums1[(i + k) % n] = nums[i]; // Yeni dizide uygun pozisyona yerleştir
            }

            // Döndürme sonrası dizi çıktısını yazdırıyoruz.
            Console.WriteLine("Döndürme Sonucunda Dizi Şu Şekildedir: " + "\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(nums1[i] + " ");
            }
        }
    }
}
