using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("are you a full time or partime student?");//asking if the student is full time or partime
            string student = Convert.ToString (Console.ReadLine());//delaring and initialiing "student" as a variable
            if (student == "full time")
           { 
            Console.WriteLine("what is your course of study?");//asks for student's course of study
            string x = Convert.ToString(Console.ReadLine());// declare and initialize x(credit) as a variable
            Console.Write("{0}",x);
            Console.WriteLine(" is a good course");//print the course as a good course
           }
            else if (student == "part time")
           {
            Console.WriteLine("how many credits are you taking?");
            int credit = Convert.ToInt32(Console.ReadLine());
            if (credit >= 0 && credit <= 6)
            Console.WriteLine("proceed to the screen");
        else if (credit > 6)
        Console.WriteLine("too much unit"); 
        }
    
    else
    {
        System.Console.WriteLine("ERROR \nplease cross check your input");
    }
    }
    }
}