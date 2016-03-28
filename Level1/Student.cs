using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1
{
   public class Student:Person
    {
        private int gpa;
        private string IdGen;
        public int GPA 
        {
            get { return gpa; }
            set { gpa = value; }
        }
        public string IDGen
        {
            get { return IdGen; }
            set { IdGen = value; }
        }
 
    }
}
