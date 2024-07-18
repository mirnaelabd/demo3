using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3.poly_overriding
{
    internal class typeB : typeA
    {
       public int b {  get; set; } 

       public typeB(int a,int b):base(a)
        {
            this.b = b;
        }
                                        //overriding 
    

        // use new key word 
        public new void  fun()
        {
            Console.WriteLine("i am deived"); // new version 
        }
 // using over_riding 
        public override void myfun2()
        {
           Console.WriteLine($"the value of a {a} and the value of b {b}");
        }

    }
}
