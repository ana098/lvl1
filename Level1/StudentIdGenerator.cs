using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1
{
    class StudentIdGenerator
    {
        static StudentIdGenerator instance = new StudentIdGenerator();
        int nextID;
        StudentIdGenerator() { 
            nextID = 1; 
        }

        public static StudentIdGenerator getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentIdGenerator();
                }
                return instance;
            }
            
        }

        public int nextId()
        {
            int number = this.nextID++;
          
            return number;
        }

    }
}
