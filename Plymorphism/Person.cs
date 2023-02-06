using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plymorphism
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public virtual void Greet()
        //{
        //    Console.WriteLine("Hi! I am a person.");
        //}

        public void Greet() {
            Console.WriteLine("Hi! I am a person.");
        }
    }

  public  class Employee : Person
    {
        public string CompanyName { get; set; }
        public decimal Salary { get; set; }

        //public override void Greet()
        //{
        //    if(this.FirstName!=null)
        //        Console.WriteLine(FirstName);
        //    Console.WriteLine("Hello! I am an employee.");
        //}

        public  void Greet()
        {
            Console.WriteLine("Hello! I am an employee.");
        }
    }


}
