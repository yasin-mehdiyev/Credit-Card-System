using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_10_2018
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------------------Sisteme Xos Gelmissiniz----------------------------");

            string selectText = "";
            int select = 0;

            Console.WriteLine("Seciminiz edin:");
            Console.WriteLine("1.Esya Al");
            Console.WriteLine("2.Sistemden Cixis");

            do
            {

                selectText = Console.ReadLine();
                while (!int.TryParse(selectText,out select))
                {
                    Console.WriteLine("Duzgun Sekilde seciminizi edin");
                    selectText = Console.ReadLine();
                }

                switch (select)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("-------------------------Credit Card System----------------------");

                        //---------------------------------------------------------------
                        Console.WriteLine("Nece ayliq kredit gotumek isdeyirsiniz?");
                        string monthStr = Console.ReadLine();
                        int month = 0;
                        while (!int.TryParse(monthStr,out month) || month<=0)
                        {
                            Console.WriteLine("Duzgun Sekilde ay sayini daxil edin");
                            monthStr = Console.ReadLine();
                        }

                        //---------------------------------------------------------------
                        Console.WriteLine("Goturmek isdediyiniz esyanin qiymetini daxil edin");
                        string priceStr = Console.ReadLine();
                        double price = 0;
                        while (!double.TryParse(priceStr, out price) || price<=0)
                        {
                            Console.WriteLine("Esyanin qiymetini duzgun sekilde daxil edin");
                            priceStr = Console.ReadLine();
                        }

                        //---------------------------------------------------------------
                        Console.WriteLine("Ayliq nece faiz kredit olmasini isdeyirsiniz?");
                        string monthPercentStr = Console.ReadLine();
                        double monthPercent = 0;
                        while (!double.TryParse(monthPercentStr, out monthPercent) || monthPercent<0)
                        {
                            Console.WriteLine("Ayliq kredit faizini duzgun sekilde daxil edin");
                            monthPercentStr = Console.ReadLine();
                        }
                        Console.WriteLine("--------------------------------");

                        //---------------------------------------------------------------
                        Console.Clear();
                        Console.WriteLine("------------------Neticeniz---------------");
                        Credit crd = new Credit(month, price, monthPercent);
                        crd.Calc();

                        //---------------------------------------------------------------

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Sistemden istifade etdiyiniz ucun tesekkurler");
                        break;
                    default:
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Size teklif edilen secimlerden birini secin");
                        break;
                }

            } while (select!=0);
        }
    }
}
