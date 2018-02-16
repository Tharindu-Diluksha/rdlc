using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bonus
    {
        private int id;
        private string type;

        public Bonus(int id, string type)
        {
            this.id = id;
            this.type = type;
        }

        public int ID
        {
            get { return id; }
        }

        public string Type
        {
            get { return type; }
        }
    }
}
