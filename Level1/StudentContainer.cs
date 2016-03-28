using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Level1
{
   public class StudentContainer:Student
    {
        List<string> list=new List<string>();  
       
       List <Student> studenti = new List<Student>();
      

        
       public void dodajNovog(Student stud){
           studenti.Add(stud);
           Console.WriteLine("Student dodan.");
       }
       public void ispisi()
       {
           studenti = studenti.OrderBy(m => m.Name).ToList();

           Console.WriteLine("------------------");
           Console.WriteLine("***ISPIS*****");
           Console.WriteLine("------------------");
           foreach (Student s in studenti){
               Console.WriteLine("Name:"+ s.Name);
               Console.WriteLine("Surname:" + s.LName);
               Console.WriteLine("GPA:" + s.GPA);
               Console.WriteLine("------------------");
           }

       }

       
    }
}
