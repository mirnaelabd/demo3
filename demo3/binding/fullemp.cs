using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.binding
{
    public class fullemp : employee
    {
        public decimal salary { get; set; }

        public fullemp(int  id, decimal Salary , string name , int age ) :base(id , name , age)
        {
            salary = Salary; 
        }
        public new void getemploye() 
        {
            Console.WriteLine("i am full time employee");

        }
        public override void getemployedata()
        {

            Console.WriteLine($"the name is {name} , age {age} , the id is {id} , the salart {salary} ");
        }
    }
}
