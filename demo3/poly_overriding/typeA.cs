using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.poly_overriding
{
    internal class typeA
    {
        public int a {  get; set; }

        public typeA(int a)
        {
            this.a = a;
        }
        public void myfun()
        {
            Console.WriteLine("I am base [persent] "); 
        }
        public virtual void myfun2()
        {
            Console.WriteLine($"TYPE A : {a} ");
        }
    }
}
