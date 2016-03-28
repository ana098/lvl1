using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1
{
    public static class Operations
    {
        private static string[] op = {"ENLIST","DISPLAY" };
        
        public static bool checkInput(string Input) 
        {
            if (op.Contains(Input))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        
    }

}
