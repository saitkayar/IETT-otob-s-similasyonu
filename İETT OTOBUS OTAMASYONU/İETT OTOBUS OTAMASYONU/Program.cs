using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace İETT_OTOBUS_OTAMASYONU
{
    class Program
    {
        static void Main(string[] args)
        {
            ucretler.baslangıc();
          
            ///rastgele sayıların olusturulması
            Random rsg = new Random();
          int  ıcerdekiler = rsg.Next(0, 20);
            Console.WriteLine("Otobüsteki Yolcu Sayısı : "+ıcerdekiler);
            Console.WriteLine();
            Console.WriteLine("Maksimum Kapasite 20 Sayısını Aşamaz\n");
            Console.WriteLine("Duraktaki Yolcu Sayısını Giriniz");
            int duraktakiler = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int toplam = ıcerdekiler + duraktakiler-20;
             if (toplam<=0)
            {
                Random rsg2 = new Random();
                int binebilecekler = rsg2.Next(0, 5);
                Console.WriteLine("Kapı Açılır\n");
                Console.WriteLine("Yolcular Bİniyor");
                  
                    for (int i = 1; i <= duraktakiler; i++)
                    {
                    Random rsg4 = new Random();
                    int Yas2 = rsg4.Next(10, 80);
                    Random rsg5 = new Random();
                    int bakiye2 = rsg5.Next(0, 50);
                    Console.WriteLine("{0}. Yolcu biniyor\n",i);
                        ucrethesplama p1 = new ucrethesplama(Yas2,bakiye2);
                         p1.bilgi();
                          Console.WriteLine();
                        p1.hesapla();
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("**********************************************");
                    Console.Clear();
                }
  
                

            }
            else if(toplam>0)
            {
                toplam = 20 - ıcerdekiler;
                Console.WriteLine("Otobüse binebilecek sayısı : "+toplam);
                if (toplam>0)
                {
                    Random rsg2 = new Random();
                    int binebilecekler = rsg2.Next(0, 5);
                    Console.WriteLine("Kapı Açılır\n");
                    Console.WriteLine("Yolcular Bİniyor");

                    for (int i = 1; i <= toplam; i++)
                    {
                        Random rsg4 = new Random();
                        int Yas2 = rsg4.Next(10, 80);
                        Random rsg5 = new Random();
                        int bakiye2 = rsg5.Next(0, 50);
                        Console.WriteLine("{0}. Yolcu biniyor\n", i);
                        ucrethesplama p1 = new ucrethesplama(Yas2, bakiye2);
                        p1.bilgi();
                        Console.WriteLine();
                        p1.hesapla();
                        Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("**********************************************");
                        Console.Clear();
                    }


                }
                else if(toplam>=0)
                {
                    ucretler.azamiyolcu();
                }

                Console.WriteLine("Kapı Kapanıyor");
            }
            Console.WriteLine("\nOtobüs Dolmuştur Sistem Kapanıyor ");
            Console.ReadLine();
        }
    
    }
}
