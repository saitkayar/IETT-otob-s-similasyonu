using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İETT_OTOBUS_OTAMASYONU
{
    class ucrethesplama:ucretler
    {
        public ucrethesplama(int yas, int bakiye)
        {
            this.yas = yas;
            this.bakiye = bakiye;
           
        }

        public int yas { get; set; }
        public int bakiye { get; set; }
        public int ucret { get; set; }

        public void hesapla ()
        {
            if (yas<18 && bakiye>10)
            {
                ucret = 10;
                yeterlises();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ücret Ödendi");
                Console.WriteLine("Kalan Bakiye : "+(bakiye-ucret));
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (yas < 18 && bakiye < 10)
            {
                ucret = 10;
                yetersizses();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yetersiz Bakiye,LÜTFEN İNİN\n");
                Console.WriteLine("Bakiyeniz : " + bakiye + " " + "En az {0} Tl Daha Yükleme Yapmalısınız", (ucret - bakiye));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (yas>18 && yas<60 && bakiye>15)
            {
                ucret = 15;
                yeterlises();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ücret Ödendi");
                Console.WriteLine("Kalan Bakiye : " + (bakiye - ucret));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (yas > 18 && yas < 60 && bakiye < 15)
            {
                ucret = 15;
                yetersizses();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yetersiz Bakiye,LÜTFEN İNİN\n");
                Console.WriteLine("Bakiyeniz : " + bakiye +" "+ "En az {0} Tl Daha Yükleme Yapmalısınız", (ucret - bakiye));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (yas>60 && bakiye > 20)
            {
                ucret = 20;
                yeterlises();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ücret Ödendi");
                Console.WriteLine("Kalan Bakiye : " + (bakiye - ucret));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (yas > 60 && bakiye < 20)
            {
                ucret = 20;
                yetersizses();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yetersiz Bakiye,LÜTFEN İNİN\n");
                Console.WriteLine("Bakiyeniz : "+ bakiye + " " + "En az {0} Tl Daha Yükleme Yapmalısınız",(ucret-bakiye));
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        public void bilgi()
        {
            Console.WriteLine("Akbilin Sahibinin Yaşı : " + yas + " Kartının Bakiyesi : " + bakiye);

            Console.ReadLine();
        }

    }
}
