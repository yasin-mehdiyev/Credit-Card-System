using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_10_2018
{
    class Credit
    {
        public int Months { get; set; }
        public double Price { get; set; }
        public double MonthlyPercent { get; set; }
        public string Currency { get; set; }

        private DateTime DateTime;

        public Credit(int ay,double qiymet,double ayliqfaiz)
        {
            this.Months = ay;
            this.Price = qiymet;
            this.MonthlyPercent = ayliqfaiz;
            this.Currency = "AZN";
        }

        public void Calc()
        {
            double total= this.Price+(this.Price * ((this.Months * this.MonthlyPercent) / 100));
            double monthlyCash = total / this.Months;
            double coins = monthlyCash % 1;
            monthlyCash -= coins;
            coins *= this.Months;
            this.DateTime = DateTime.Now;

            for (int i = 0; i < this.Months; i++)
            {
                if ((i + 1) == this.Months)
                {
                    monthlyCash += coins;
                }
                Console.WriteLine("Odenis Tarixi: "+this.DateTime.ToString("dd.MM.yyy")+" "+"Mebleg: "+monthlyCash+" "+this.Currency);
                this.DateTime = this.DateTime.AddMonths(1);
            }
        }
    }
}
