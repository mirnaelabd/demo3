using demo3.binding;
using demo3.poly_overriding;


namespace demo3


{



/*    public static void process(employee employee)
    {
        if (employee is not null)
        {
            employee.getemployedata();
            employee.getemploye();
        }
    }*/
    internal class Program
    {

        #region overloading 

        //method overloading  use for readability  
        public static int sum(int x , int y )
        {

        return x + y;
        }
        public static double sum(double x, double y)
        {

            return x + y;
        }
        public static int sum(int x, int y,int z)
        {

            return x + y+z;
        }
        public static double sum  (int x , double y )
        {

        return x + y;
        }
        public static double sum( double y, int x)
        {

            return x + y;
        }


        #endregion
        static void Main()
        {
            #region poly [overloading]
            /*    int result =  sum(2, 3);
                Console.WriteLine( result );
                int result2= sum(2, 3 , 4 );
                Console.WriteLine(result2);
                double result3 = sum(2.6, 3.4);
                Console.WriteLine(result3);*/

            #endregion
            #region poly[over_ridding]
            // suported with class only 
            // must be inhertance 

            /*     typeA typea = new typeA(1);
                 typea.a = 2;
                 typea.myfun();
                 typea.myfun2();

                 typeB typeb = new typeB(2,4);
                 typeb.a = 9; 
                 typeb.b= 7; 
                 typeb.myfun();
                 typeb.myfun2();  */
            #endregion
            #region binding 
            /*   typeA refbase; 
               refbase=new typeB(1,2);
               refbase.a= 1;
               //  refbase.b = 2; // invalid
               refbase.myfun(); // i am base 
               refbase.myfun2(); // the value of a 1 and the value of b 2*/

            #endregion

            #region not binding 
            /*     typeA typea = new typeB(1, 2);
                 typeB typeb = (typeB) typeA ;*/

            #endregion
            #region ex1 of binding 
            /*    fullemp emp = new fullemp(12, 2333, "mirna ", 23);
                if (emp is not null)
                {
                    emp.getemployedata();
                    emp.getemploye();
                }*/

            /*     partemp emp2 = new partemp()
                 {
                     id = 1,
                     hourRate = 2.3M,
                     age = 33,
                     name = "ahmed ",
                     countofhour = 40

                 };
                 process(emp2); */

            #endregion

            #region ex2 of binding 

            typeA typea = new typeC(1, 2, 3);
            typea.a = 10;
            typea.myfun();
            typea.myfun2();
            #endregion



        }
    }
}
