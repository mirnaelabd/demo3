using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.binding
{
    public class partemp : employee
    {
        public int countofhour { get; set; }
        public decimal hourRate { get; set; }

        public partemp(int Countofhour, decimal HourRate, int id, string name, int age) : base(id, name, age)
        {
            countofhour = Countofhour;
            hourRate = HourRate;
        }
        public new void getemploye()
        {
            Console.WriteLine("i am part time employee");


        }

        public override void getemployedata()
        {
            Console.WriteLine($"the name is {name} and age {age} and the id is {id} , the  countofhour is {countofhour}  , hour rate is {hourRate} ");
        }
    }
}
