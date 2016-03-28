using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1
{
    public abstract class Person
    {
        private string name;
        private string lname;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LName
        {
            get { return lname; }
            set { lname = value; }
        }
    }
}
