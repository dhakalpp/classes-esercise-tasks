using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class priyanka
    {
        /*Attributes*/
        string fname;
        string lname;
        int age;
        /*Attributes getters ans setter (combined make properties)*/
        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }
        /*constructer*/
        public priyanka(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;
        }
    }
}
