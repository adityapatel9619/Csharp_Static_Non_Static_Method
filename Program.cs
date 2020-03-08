using System;

namespace Static_Non_Static_Method
{
    class Program
    {

    // **Refernce Type Method**
        //Static & Non-Static Method Declaration
            
            //Static Method
        static void name()
        {
            Console.WriteLine("I am from Static Class");
        }

            //Non-Static Method

        public void name1()
        {
            Console.WriteLine("I am from Non-Static Class");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("********Program.cs********");
            //Calling Static Method 
            name();

            //Calling Non-Static Method
            //To call non-static method we have to make instance and and call the non-static method

            Program m = new Program();
            m.name1();

            Console.WriteLine("********Class1.cs********");
            /*Here we will call methods from Class1.cs*/

            //Calling Non-Static Method from Class1.cs
            Class1.name2();

            //Calling Static Method from Class1.cs
            Class1 c = new Class1();
            c.name3();
            
            
        }
    }
}
