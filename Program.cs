using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadZaVJ2
{
    class KlasaB
    {
       public string BezPrvogIZadnjeg(string bpiz)
        {
            bpiz = bpiz.Remove(bpiz.Length-1,1);
            bpiz=bpiz.Remove(0,1);
            return bpiz;
        }
    }
    internal class Program
    {
        /*Definirajte klasu KlasaB sa sljedećim članicama:
• metoda
string BezPrvogIZadnjeg(string) koja će vratiti proslijeñeni string bez prvog i
zadnjeg znaka.
Definirajte objekt tipa KlasaB, zatražite od korisnika da unese niz znakova, te taj niz znakova
proslijedite metodi BezPrvogIZadnjeg, a povratnu vrijednost ispišite. Osigurajte pritom da se
metoda pozove samo ako je korisnik unio više od 2 znaka.*/
        static void Main(string[] args)
        {
            KlasaB klasaB = new KlasaB();
            Console.WriteLine("Unesi niz znakova: ");
            string s =Console.ReadLine();
            
            Console.WriteLine(klasaB.BezPrvogIZadnjeg(s));
            Console.ReadKey();
        }
    }
}
