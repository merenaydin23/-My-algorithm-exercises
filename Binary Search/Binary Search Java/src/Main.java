import java.util.*;

public class Main {
    public static void main(String[] args) {
        // Rastgele sayılar üretmek için Random nesnesi
        Random rand = new Random();

        // Kullanıcıdan giriş almak için Scanner nesnesi
        Scanner klavye = new Scanner(System.in);

        int uzunluk;

        // Kullanıcıdan geçerli bir dizi uzunluğu alınır
        do {
            System.out.println("Lütfen dizinizin uzunluğunu giriniz (pozitif bir sayı):");
            uzunluk = klavye.nextInt();
        } while (uzunluk <= 0);  // Geçersiz giriş için tekrar sorulur

        System.out.println("Random sıralanmış diziniz oluşturuluyor...");

        // Boş bir dizi oluşturulur ve rastgele sayılarla doldurulur
        int[] dizi = new int[uzunluk];
        for (int i = 0; i < uzunluk; i++) {
            dizi[i] = rand.nextInt(400) - 100;  // -100 ile 300 arası sayılar
        }

        // Diziyi sıralıyoruz
        int[] sıralanmışDizi = sıralama(dizi);

        // Sıralanmış diziyi ekrana yazdırıyoruz
        System.out.print("Sıralanmış diziniz: ");
        for (int i = 0; i < uzunluk; i++) {
            System.out.print(sıralanmışDizi[i] + " ");  // Elemanlar arasına boşluk ekliyoruz
        }
        System.out.println();  // Satır sonu

        // Kullanıcıdan aradığı elemanı alıyoruz
        System.out.println("Dizide aradığınız elemanı giriniz:");
        int aranan = klavye.nextInt();

        // Binary Search ile arama yapıyoruz
        BinarySearch(sıralanmışDizi, aranan);
    }

    // Bubble Sort algoritması ile diziyi sıralama
    public static int[] sıralama(int[] dizi) {
        int temp;
        // Bubble Sort ile diziyi sıralıyoruz
        for (int i = 0; i < dizi.length; i++) {
            for (int j = i + 1; j < dizi.length; j++) {
                if (dizi[i] > dizi[j]) {
                    temp = dizi[i];
                    dizi[i] = dizi[j];
                    dizi[j] = temp;
                }
            }
        }
        return dizi;
    }

    // Binary Search algoritması ile dizide arama yapma
    public static void BinarySearch(int[] dizi, int aranan) {
        int ilkTerim = 0;
        int sonTerim = dizi.length - 1;
        int toplam;
        boolean kontrol = false;

        // Binary Search araması
        while (ilkTerim <= sonTerim) {
            toplam = (ilkTerim + sonTerim) / 2;

            if (dizi[toplam] > aranan) {
                sonTerim = toplam - 1;
            } else if (dizi[toplam] < aranan) {
                ilkTerim = toplam + 1;
            } else {
                System.out.println("Aradığınız eleman dizinin " + toplam + ". indexinde bulundu.");
                kontrol = true;
                break;
            }
        }

        if (!kontrol) {
            System.out.println("Aradığınız eleman dizide bulunamadı.");
        }
    }
}