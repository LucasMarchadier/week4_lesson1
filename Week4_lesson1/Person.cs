using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_lesson1
{
    class Person
    {
        public string name;

        public Person()
        {
            this.name = " ";
        }

        public Person(string n)
        {
            this.name = n;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            return "Name : " + this.name;
        }


    }
}
