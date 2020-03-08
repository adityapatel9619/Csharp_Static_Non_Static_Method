using System;


namespace Static_Non_Static_Method
{
    class Class1
    {
        /* 
         Now we will declare method in this class and we will call from Program.cs 
         */
              
        
        //Non-Static Method
        public static void name2()
        {
            Console.WriteLine("I am Non-Static Class From  Class1");
        }

        //Static Method
        public void name3()
        {
            Console.WriteLine("I am Static Class From  Class1");
        }


    }
}
