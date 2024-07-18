using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.poly_overriding
{
    internal class typeD :typeC
    {
        public int d {  get; set; }
        public typeD (int d , int a , int b , int c ):base ( a , b , c )
        {
            this.d = d;
        }
        public new void myfun()
        {
            Console.WriteLine("dervied [child of grand child");
        }
        public new virtual void myfun2()
        {
            Console.WriteLine($"the value of a {a} and the value of b {b} , the value of c is {c} , the value of d {d} ");
        }

    }
}
