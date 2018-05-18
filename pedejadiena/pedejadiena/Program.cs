using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedejadiena
{
    class Program
    {
        static void Main(string[] args)


        {
            pedeja tassk = new pedeja();

            int woilaskaitlis = tassk.Saskaita(2, 2);
            Console.WriteLine(woilaskaitlis);





            int izvelies = 1; //man vajaga lai mainigajam ir vertiba lai vins parbauda ka vertiba nav vienada ar nulli
            //lai vins vispar ieietu ieksa cikla.
            //izmanto vertibu parbauda un tad dara

            while (izvelies != 0)
            {
                Console.WriteLine("****SPIED 66 - JA VĒLIES SASKAITĪT****");
                Console.WriteLine("****SPIED 99 - JA VĒLIES ATŅEMT****");
                // Console.WriteLine("69- ");
                // Console.WriteLine("96- ");
                Console.WriteLine("SPIED 0- JA VĒLIES DOTIES PROM");

                string input = Console.ReadLine();
                izvelies = Convert.ToInt16(input);

                switch (izvelies)
                {
                    case 66:
                        Skaitlispoz();
                        break;
                    case 99:
                        Skaitlisneg();
                        break;

                    case 0:
                        izvelies = 0;
                        break;
                    default:
                        Console.WriteLine("ERRRROOOOOOOORRRR");
                        break;
                }
                pedeja2 pedejaaa = new pedeja2();
            }

            Console.WriteLine("***Ievadi divus skaitļus***");
            Skaitlispoz(); //izsaucu funkciju  kura ir arpus main funkcijas
            Skaitlisneg();

            Console.ReadLine();
        }
        static void Skaitlispoz() //funkcija kura panem lietotaja ievaditu stringu  parkonverte uz intu
        {//...un tad es pasaku kas vinam jadara ar tiem skaitliem
            Console.WriteLine("IEVADI LUDZU PIRMO SKAITLI ");//PASAKU VINAM KO DARIT
            string ievade = Console.ReadLine();//VINS IEVADA SKAITLI
            int skaitlis1 = Convert.ToInt16(ievade);//VINS KONVERTE UZ INT


            Console.WriteLine("IEVADI LUDZU OTRO SKAITLI ");
            string ievade2 = Console.ReadLine();
            int skaitlis2 = Convert.ToInt16(ievade2);

            int skp = skaitlis1 + skaitlis2;
            Console.WriteLine(skaitlis1 + "+" + skaitlis2 + "=" + skp);
           // Console.WriteLine(skaitlis1 + skaitlis2);

                 
        }
        static void Skaitlisneg()//tiesi tas pats tikai atnemsana
        {
            Console.WriteLine("IEVADI LUDZU PIRMO SKAITLI ");
            string ievade = Console.ReadLine();
            int skaitlis1 = Convert.ToInt16(ievade);


            Console.WriteLine("IEVADI LUDZU OTRO SKAITLI ");
            string ievade2 = Console.ReadLine();
            int skaitlis2 = Convert.ToInt16(ievade2);

            int skn = skaitlis1 - skaitlis2;
            Console.WriteLine(skaitlis1 +  "-" + skaitlis2 + "=" + skn);




            pedeja saskaita = new pedeja();
        }
    }
}
