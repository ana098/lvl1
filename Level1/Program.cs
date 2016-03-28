using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StudentContainer novi = new StudentContainer();
            StudentContainer ListaStudenata = new StudentContainer(); 
            int IdGen = StudentIdGenerator.getInstance.nextId();
            int b=0;
            string operacija="";

            while (true)
            {
                while (Operations.checkInput(operacija)==false)
                {
                    Console.WriteLine("Operation: ");
                    operacija = Console.ReadLine().ToString().ToUpper();
                }
                
                    if (operacija=="ENLIST")
                    {
                        Student s = new Student();

                        Console.WriteLine("Student");
                        Console.WriteLine("First name: ");
                        s.Name = Console.ReadLine();
                        while (s.Name.Length == 0) { 
                            Console.WriteLine("You need to insert value"); 
                            s.Name = Console.ReadLine(); 
                        }
                       
                        Console.WriteLine("Last Name: ");
                        s.LName = Console.ReadLine();
                        while (s.LName.Length == 0) { 
                            Console.WriteLine("You need to insert value"); 
                            s.LName = Console.ReadLine(); 
                        }
                       
                        Console.WriteLine("Unesite GPA broj: ");
                        string g = Console.ReadLine();
                        while (g.Length == 0) { 
                            Console.WriteLine("You need to insert value"); 
                            g = Console.ReadLine(); 
                        }
                        while (!Int32.TryParse(g, out b)) { 
                            Console.WriteLine("You need to insert numerical value, try again!!"); 
                            Console.ReadLine(); 
                        }
                        s.GPA = b;  

                        s.IDGen = StudentIdGenerator.getInstance.nextId().ToString();
                       // Console.WriteLine("ID  " + s.IDGen);

                        ListaStudenata.dodajNovog(s);
                        operacija = "";

                    }
                    else if (operacija == "DISPLAY")
                    {

                        ListaStudenata.ispisi();
                        Console.WriteLine("Ispis gotov");
                        Console.ReadLine();
                        //System.Environment.Exit(1);
                    }
                    else
                    {
                        
                    }

            }
            

        }
    }
}
