
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**		 BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**			 NESNEYE DAYALI PROGRAMLAMA DERSİ
**				2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Homework 1 
**				ÖĞRENCİ ADI............: Sümeyye Üstün
**				ÖĞRENCİ NUMARASI.......: B211210065
**              DERSİN ALINDIĞI GRUP...: 1B
****************************************************************************/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPOdev
{

    public static class Denetim
    {
        public static int BuyukH(string sifre)
        {
            char[] buyuk = { 'A','B','C','D','E','F','G','Ğ','H','I','İ','J','K','L','M','N','O','Ö','P','R','S','Ş','T','U','Ü','V','Y','Z','W','Q'};
            int buyukHarfSayısı = 0;
            foreach ( buyuk)
                //foreach döngüsü ile buyuk dizisindeki verileri sırayla b değişkenine atarız.
            {
                for (int i = 0; i < sifre.Length; i++)
                    // Şifrenin her bir elemanı kontrol edilerek büyük harf kontrolü yapılır.
                {
                    if (b == sifre[i])
                    //Büyük harf var ise büyük harf sayacı için büyük harf sayısı arttırılır.
                    {
                        buyukHarfSayısı++;
                    }
                }
            }

            return buyukHarfSayısı;
        }


        public static int KucukH(string sifre)
        {
            char[] kucuk = { 'a','b','c','d','e','f','g','ğ','h','ı','i','j','k','l','m','n','o','ö','p','r','s','ş','t','u','ü','v','y','z','w','q'};
            int kucukHarfSayısı = 0;
            foreach (char k in kucuk)
                //foreach döngüsü ile kucuk dizisindeki verileri sırayla k değişkenine atarız.
            {
                for (int i = 0; i < sifre.Length; i++)
                // Şifrenin her bir elemanı kontrol edilerek küçük harf kontrolü yapılır.
                {
                    if (k == sifre[i])
                        //Küçük harf var ise küçük harf sayacı için küçük harf sayısı arttırılır.
                    {
                        kucukHarfSayısı++;
                    }
                }
            }


            return kucukHarfSayısı;
        }


        public static int Sembol(string sifre)
        {

            int sembolSayısı = 0;

            string Ab1 = "ABCDEFGĞHIİJKLMNOÖPRSŞTUÜVYZWQabcdefgğhıijklmnoöprsştuüvyzwq1234567890";

            for (int i = 0; i < sifre.Length; i++)
                //Şifredeki her bir elemanı kontrol eder.
            {
                if ( -1 == Ab1.IndexOf(sifre[i]))
                    //Ab1 deki elemanları içeriyor mu diye IndexOf() fonksiyonu ile konrtol yapılır. İçermiyorsa ( -1 çıktısını verir) sembol sayısı arttırılır.
                {
                    sembolSayısı++;
                }
            }

            return sembolSayısı;
        }


        public static int Rakam(string sifre)
        {
            char[] rakam = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int rakamSayısı = 0;
            foreach (char r in rakam)
                //foreach döngüsü ile rakam dizisindeki verileri sırayla r değişkenine atarız.
            {
                for (int i = 0; i < sifre.Length; i++)
                // Şifrenin her bir elemanı kontrol edilerek rakam kontrolü yapılır.
                {
                    if (r == sifre[i])
                        //Rakam var ise rakam sayacı için rakam sayısı arttırılır.
                    {
                        rakamSayısı++;
                    }
                }
            }

            return rakamSayısı;
        }


    }



    // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen şifre giriniz.");
            bool Kontrol=false;
            
            string sifre= Console.ReadLine();

            for(int i=0; i<sifre.Length; i++)
                // Şifrenin her bir elemanı için şifrede boşluk bulunup bulunmadığına bakılır.
            {
                if(sifre[i] ==' ')
                {
                    Kontrol = true;
                }
            }
            if (sifre.Length <9)
                // Şifre uzunluğunun 9 karakterden az olup olmadığı kontrol edilir.
            {
                Kontrol = true;

            }
            if(Kontrol==true)
                // Kontrolün true olması istemediğimiz bir durum olduğu için true durumlarında sistemin şifreyi kabul etmemesini sağlarız.
            {
                Console.WriteLine("Şifre kabul edilemedi. Şifre 9 karakterden kısa ya da boşluk içeriyor");
                
            }
            else
            {
                int buyukHarfSayısı = Denetim.BuyukH(sifre);
                int kucukHarfSayısı = Denetim.KucukH(sifre);
                int sembolSayısı = Denetim.Sembol(sifre);
                int rakamSayısı = Denetim.Rakam(sifre);
                Console.WriteLine("Büyük harf sayısı : " + buyukHarfSayısı);

                Console.WriteLine("Küçük harf sayısı :" + kucukHarfSayısı);

                Console.WriteLine("Sembol sayısı:" + sembolSayısı);

                Console.WriteLine("Rakam sayısı :" + rakamSayısı);
                //++++++++
                int puan = 0;
                // Şifredeki büyük harf,küçük harf sembol ve rakamın her birinnin kendi türü içinde max 20 puan verilecek şekilde puan hesabı yaptırılır.
                if (buyukHarfSayısı == 1)
                {
                    puan += 10;
                }
                else if (buyukHarfSayısı > 1)
                {
                    puan += 20;
                }
               
                if (kucukHarfSayısı == 1)
                {
                    puan += 10;
                }
                else if (kucukHarfSayısı > 1)
                {
                    puan += 20;
                }

                puan += 10 * sembolSayısı;

                if (rakamSayısı == 1)
                {
                    puan += 10;
                }
                else if (rakamSayısı > 1)
                {
                    puan += 20;
                }


                if (sifre.Length == 9)
                    // Şifre 9 karakter ise 10 puan ilave edilir.
                {
                    puan += 10;
                }



                //++++++++




                if (buyukHarfSayısı==0 || kucukHarfSayısı==0 || sembolSayısı==0 || rakamSayısı==0 )
                    // Büyük harf, küçük harf, sembol ve rakam sayısının 0 a eşit olmaması kontrol edilir.
                {
                    Console.WriteLine("Şifreniz geçersiz. Küçük harf, büyük harf, sembol ve rakam sayısı 0' a eşit olamaz. ");
                }
                // Aşağıdaki else if bloklarında ise puan hesabına göre şifrenin güçlülüğü hakkında ekrana mesaj verilir.
                else if (puan<70)
                {
                    Console.WriteLine("Şifreniz kabul edilemedi. Zayıf şifre.");
                }
                else if ( puan < 90 && puan>=70)
                {
                    Console.WriteLine("Orta güçlükteki şifre.");
                }
                else if ( puan >= 90 && puan <= 100)
                {
                    Console.WriteLine("Güçlü şifre.");
                }

            }
            Console.WriteLine("Çıkış yapmak için herhangi bir tuşa basınız.");
            Console.ReadKey();

        }
    }

}
