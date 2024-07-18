using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.binding
{
    public class employee
    {
        public employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int id {  get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public void getemploye()
        {
            Console.WriteLine("i am employee"); 

        }
        public virtual void getemployedata()
        { 
            Console.WriteLine($"the name is {name} and age {age} and the id is {id} ");
        }
            
    }
}
