using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsOOP
{
    internal class Person
    {
        public string name;
        public int experience = 0;

        public Person(string name)
        {
            this.name = name;
        }

        public virtual void PrintStatsInfo()
        {
            Console.WriteLine($"Person: {this.name} - {this.experience} EXP");
        }

        private void Reset()
        {
            this.name = "Not assigned";
            this.experience = 0;
        }
    }
}
