//using System;

class LeetCode
{
    static void Main()
    {
        int length;
        // Dizinin uzunluğunu kullanıcıdan al, 1 ile 100000 arasında olmasını sağla
        do
        {
            Console.WriteLine("Lütfen dizinin uzunluğunu giriniz (1 - 100000): ");
            length = Convert.ToInt32(Console.ReadLine());
        } while (length < 1 || length > 100000);

        int[] nums = new int[length]; // Kullanıcının gireceği dizi

        Console.WriteLine("Lütfen dizinin elemanlarını giriniz: ");
        for (int i = 0; i < nums.Length; i++)
        {
            int j = i + 1; // Kullanıcıya eleman numarasını göstermek için
            Console.Write(j + ". eleman = ");
            nums[i] = Convert.ToInt32(Console.ReadLine()); // Elemanı kullanıcıdan al
        }

        // Diziyi sıralamak için metodu çağır
        Console.WriteLine("Dizinizin Sıralanmış hali: ");
        int[] nums1 = sortingArray(nums);
        for (int i = 0; i < nums1.Length; i++)
        {
            Console.Write(nums1[i] + " "); // Sıralı diziyi ekrana yazdır
        }

        int k;
        // Kullanıcıdan en büyük kaçıncı elemanı istediğini al
        do
        {
            Console.WriteLine();
            Console.WriteLine("Dizinizin en büyük kaçıncı elemanını öğrenmek istersiniz? ");
            k = Convert.ToInt32(Console.ReadLine());
        } while (k < 1 || k > length); // k'nın geçerli olup olmadığını kontrol et  burada k>lenght ve k>100.000 durumunu kullanrak k>100.000 fazlalık olduğunu gördük ve sildik .

        // k'nıncı en büyük elemanı bul
        int result = FindKthLarges(nums, k);
        if (result == -1)
        {
            Console.WriteLine("Değer hesaplanamıyor"); // Hata durumu
        }
        else
        {
            // Sonucu ekrana yazdır
            Console.Write("Dizinin en büyük " + k + ". elemanı = " + result);
        }
    }

    // Diziyi azalan sırada sıralayan metot
    static int[] sortingArray(int[] nums)
    {
        int temp;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                // Eğer j. eleman i. elemandan büyükse yer değiştir
                if (nums[j] > nums[i])
                {
                    temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                }
            }
        }
        return nums; // Sıralanmış diziyi döndür
    }

    // k'nıncı en büyük elemanı bulan metot
    static int FindKthLarges(int[] nums, int k)
    {
        if (k == 1) // Eğer k 1 ise en büyük elemanı döndür
        {
            return nums[0];
        }

        int sıra = 1; // Sıra değişkenini başlat
        if (nums.Length == 1) // Eğer dizi sadece bir elemandan oluşuyorsa
        {
            return nums[0];
        }

        // Dizinin elemanlarını kontrol et
        for (int i = 0; i < nums.Length - 1; i++)
        {
            // Eğer bir sonraki eleman daha küçükse
            if (nums[i + 1] < nums[i])
            {
                sıra++; // Sıra değişkenini artır
                if (sıra == k) // Eğer sıra k'ya eşit olduysa
                {
                    return nums[i + 1]; // k'nıncı en büyük elemanı döndür
                }
            }
        }

        // Eğer tüm elemanlar eşitse
        if (sıra == 1 && k == 1)
        {
            Console.WriteLine("Dizinin tüm elemanları da aynı değere sahiptir.");
            return nums[0]; //  dizinin hangi değeri dönerse doğru olur çünkü tüm elemanlar eşittir 
        }

        return -1; // Eğer bu ihtimallerin hiç birine en sonda girmiyorsa -1 dönderir
    }
}
