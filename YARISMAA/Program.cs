using System;
namespace yarısma
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogruSayisi = 0;
            Console.WriteLine("Kim Milyoner Olmak İster");
            Console.WriteLine("Bu bir bilgi yarışmasıdır");
            Console.WriteLine("3 Sorudan 2 sini dogru cevaplarsanız büyük ödül sizin olabilir");
            Console.WriteLine("Lütfen soruları dikkatli okuyunuz!");

            // 1.soru

            Console.WriteLine(" Hangi hayvan dilini gösterirse sokmaz?");
            Console.WriteLine("a) yılan b)timsah");
            Console.WriteLine("Cevabınız:");
            string cevap1 = Console.ReadLine().ToLower();

            if (cevap1 == "a")
            {
                dogruSayisi++;
                Console.WriteLine("Dogru");
            }
            else
            {
                Console.WriteLine("Yanlış");
            }

            // 2.soru

            Console.WriteLine("Hangi gezegende su bulundu?");
            Console.WriteLine("A) Mars b)Satürn");
            Console.WriteLine("Cevabınız");
            string cevap2 = Console.ReadLine().ToLower();

            if (cevap1 == "a")
            {
                dogruSayisi++;
                Console.WriteLine("Dogru");
            }
            else
            {
                Console.WriteLine("Yanlış");
            }

            if (dogruSayisi < 2)
            {
                Console.WriteLine("Üzgünüm Büyük Ödül Başkasına Nasipmiş");
                return;
            }

            //3.soru

            Console.WriteLine("3 -> 3 * 5+ 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
            Console.WriteLine("a)7 b)17");
            String cevap3 = Console.ReadLine().ToLower();

            if (cevap3 == "b")
            {
                dogruSayisi++;
                Console.WriteLine("Dogru");
            }
            else
            {
                Console.WriteLine("Yanlış");
            }

            //end
            if (dogruSayisi >= 2)
            {
                Console.WriteLine("Tebrikler 1 Milyon TL kazandınız");
            }
            else
            {
                Console.WriteLine("Hay Şansının ben");
            }

        }
    }
}



