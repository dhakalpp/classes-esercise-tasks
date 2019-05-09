using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task2*/
            priyanka Priyanka = new priyanka("Priyanka", "Dhakal", 21);
            Console.WriteLine("person's details");
            Console.WriteLine($"Name: {Priyanka.Fname} {Priyanka.Lname}\nAge: {Priyanka.Age}");
            string fname, lname;
            int age;
            fname = Console.ReadLine();
            lname = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            priyanka priyanka = new priyanka(fname, lname, age);



        }
        
        
           

            
        
    }
}
