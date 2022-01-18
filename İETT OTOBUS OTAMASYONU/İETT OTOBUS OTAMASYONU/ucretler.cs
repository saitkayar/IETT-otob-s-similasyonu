using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace İETT_OTOBUS_OTAMASYONU
{
    class ucretler
    {
       
        public void yeterlises()
        {

            SoundPlayer ses2 = new SoundPlayer();
            string yol2;
            yol2 = @"C:\Users\LENOVO\source\repos\İETT OTOBUS OTAMASYONU\İETT OTOBUS OTAMASYONU\yeterli.wav";
            ses2.SoundLocation = yol2;
            ses2.Play();
            

        }

        public void yetersizses()
        {
            SoundPlayer ses = new SoundPlayer();
            string yol;
            yol = @"C:\Users\LENOVO\source\repos\İETT OTOBUS OTAMASYONU\İETT OTOBUS OTAMASYONU\yetersiz.wav";
            ses.SoundLocation = yol;
            ses.Play();
         
        }
        public static void azamiyolcu()
        {
            Console.WriteLine("Otobüs Doludur Başka Yolcu binemez");
        }

        public  static void baslangıc()
        {
            Console.WriteLine("Otobüs Durağa Yaklaşıyor\n");
            Console.WriteLine("Kapılar Açılıyor");



        }

    }
}
