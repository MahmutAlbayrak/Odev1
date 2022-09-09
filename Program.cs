internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Asagidaki uygulamalar hangisini calistirmak istiyorsaniz kodunu giriniz");
        Console.WriteLine("1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.");
        Console.WriteLine("2. Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.");
        Console.WriteLine("3. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.");
        Console.WriteLine("4. Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.");

        int odevKod =Convert.ToInt32(Console.ReadLine());

        switch (odevKod)
        {
            case 1:
                Console.WriteLine("Pozitif bir sayi giriniz: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} adet pozitif sayi giriniz: ",n1);
                int[] sayiDizisi = new int[n1];

                for (int i = 1; i <= n1; i++)
                {
                    Console.WriteLine("{0}. sayiyi giriniz: ",i);
                    sayiDizisi[i-1]=Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Girdiginiz sayilar arasindaki pozitif sayilar: ");
                for (int i = 1; i <= n1; i++)
                    if (sayiDizisi[i-1]%2==0)
                        Console.WriteLine(sayiDizisi[i-1]);
                break;

            case 2:
                Console.WriteLine("Pozitif bir sayi giriniz: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pozitif bir sayi daha giriniz: ");
                int m2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} adet pozitif sayi giriniz: ",n2);
                int[] sayiDizisi2 = new int[n2];

                for (int i = 1; i <= n2; i++)
                {
                    Console.WriteLine("{0}. sayiyi giriniz: ",i);
                    sayiDizisi2[i-1]=Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Girdiginiz sayilar arasindaki {0} degerine tam bolunen sayilar: ",m2);
                for (int i = 1; i <= n2; i++)
                    if (sayiDizisi2[i-1]%m2==0)
                        Console.WriteLine(sayiDizisi2[i-1]);

                break;
            case 3:
                Console.WriteLine("Pozitif bir sayi giriniz: ");
                int n3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} adet kelime giriniz: ",n3);
                string[] kelimeDizisi = new string[n3];

                for (int i = 1; i <= n3; i++)
                {
                    Console.WriteLine("{0}. kelimeyi giriniz: ",i);
                    kelimeDizisi[i-1]=Console.ReadLine().ToString();
                }

                kelimeDizisi.Reverse();
                foreach (var item in kelimeDizisi)
                {
                    Console.WriteLine(item);
                }

                break;
            case 4:
                Console.WriteLine("Bir cumle yaziniz: ");
                string cumle = Console.ReadLine().ToString();
                string[] cumledizi = cumle.Split(" ");
                int kelimeSayisi = cumledizi.Length;
                
                int harfSayisi = 0;
                foreach (char item in cumle)
                {
                    harfSayisi+=1;
                }
                Console.WriteLine(kelimeSayisi);
                Console.WriteLine(harfSayisi);
                break;

            default:
                Console.WriteLine("Yanlis giris yaptiniz!");
                break;
        }
        
    }

}