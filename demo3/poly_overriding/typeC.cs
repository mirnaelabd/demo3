using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.poly_overriding
{
    internal class typeC : typeB
    {
        public int c {  get; set; }
        public typeC(int c , int a , int b ) : base( a , b )    
        {
            this.c = c;
        }
        public new void myfun()
        {
            Console.WriteLine(" i am deived [grand child ]");
        }
        public override void myfun2 ()
        {
            Console.WriteLine($"the value of a {a} and the value of b {b} , the value of c is {c} ");
        }
    }
}
