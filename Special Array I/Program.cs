using System;
using System.Reflection.Metadata;

class Solution
{
    static void Main()
    {
        int member;
        do
        {
            Console.Write("Dizinin uzunluğunu girini ");
            string input = Console.ReadLine();   // Dizinin uzunluğuunu aldık ve alt satırla beraber int türüne çevirdik
            member = Convert.ToInt32(input);
        } while (member >= 101 || member <= 0);

        int[] nums = new int[member];
        Console.WriteLine("Dizinin Elemanlarını Girin");
        for (int i = 0; i < nums.Length; i++)
        {
            string input1 = Console.ReadLine();
            nums[i] = Convert.ToInt32(input1);
            if (nums[i] < 1 || nums[i] > 100)
            { // eğer dizide girilen sayı değerleri 100 ile 1 dahil olamk üzere arasında değilse tekrar girmesini istedik
                i--;
                Console.WriteLine("Girilen Sayı 100 >= x >= 1 arasında olmalı ");
            }

        }
        bool result = isArraySpecial(nums);
        if (result)
        {
            Console.WriteLine("Özel Bir Dizidir");
        }
        else
        {
            Console.WriteLine("Özel Bir Dizi Değildir");

        }

    }
    public static bool isArraySpecial(int[] nums)
    {
        if (nums.Length == 1)  // Eğer dizinin uzunlığu 1 ise Özel Dizidir
        {
            return true;
        }
        else   // Eğer Dizinin uzunluğu 1 den farklı ise else içinde kontrol edilir
        {
            int kalan1, kalan2;
            for (int i = 1; i < nums.Length; i++)
            {
                kalan1 = nums[i] % 2;
                kalan2 = nums[i - 1] % 2;
                if (kalan1 == kalan2) // kalan 1 ve kalan 2 eğer aynı değere sahip sisitem direk false değerini döndürür ve durur
                {

                    return false;

                }
            }
            return true;  // if içine eğer sonuna kadar hiç girmemişse sistem true döndürür
        }
    }


}

