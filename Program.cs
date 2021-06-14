using System;


//tuple contains data having different data types
//tuple includes max 8 elements
//used when you want to pass multiple values in single parameter
namespace Tuple_in_c_sharp
{
    class Program
    {
       
         //tuple as method parameter
       //create static method
  
        static void Dis(Tuple<int,string,string> person)
        {
            Console.WriteLine($"{person.Item1}");
            Console.WriteLine($"{person.Item2}");
            Console.WriteLine($"{person.Item3}");
        }
        //now goto main method
        //-----------------------------------
        static void Main()
        {
            //------------------------------------------

            //creating instance of tuple that hold tu record
            //  ex-  Tuple<int, string, string> tu = new Tuple<int, string, string>(10, "roshi", "dubey");

            //creating tuple

            var tt = Tuple.Create(1, 2, 3, 4, "roshi");

            //accessing items
            Console.WriteLine(tt.Item1); //1
            Console.WriteLine(tt.Item2);//2
            Console.WriteLine(tt.Item5);  //roshi

            //--------------------------
            //nested tuple
            var to = Tuple.Create(1, 2, 3, 4, "roshi", Tuple.Create(45, 67, 78));

            //accessing items
            Console.WriteLine(to.Item1); //1
            Console.WriteLine(to.Item2);//2
            Console.WriteLine(to.Item5);  //roshi
            Console.WriteLine(to.Item6.Item1);      //45

            //------------------------------------------
            //tuple as method parameter
            var person = Tuple.Create(1, "roshi", "dubey");
            Dis(person);



        }


    }
}
