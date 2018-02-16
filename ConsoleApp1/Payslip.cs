using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Payslip
    {
        private int id;
        private string name;
        private List<Bonus> bonuses;
        

        public Payslip(int id, string name, List<Bonus> bonuses)
        {
            this.id = id;
            this.name = name;
            this.bonuses = bonuses;
        }

        public string Account { set; get; }

        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public List<Bonus> Bonus
        {
            get { return bonuses; }
        }

    }
}
