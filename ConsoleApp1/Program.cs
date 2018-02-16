using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bonuses = new List<Bonus>();

            for (int i=1; i<4; i++)
            {
                bonuses.Add(new Bonus(i, "a"+i.ToString()));
            }
            var payslip1 = new Payslip(001, "Tharindu", bonuses);

            bonuses.Add(new Bonus(005, "b"));
            bonuses.Add(new Bonus(006, "b"));

            var payslip2 = new Payslip(002, "Tharindu", bonuses);
            payslip2.Account = "Tharindu's Account";

            Console.WriteLine(payslip1);
            Console.WriteLine(payslip2.Account);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
