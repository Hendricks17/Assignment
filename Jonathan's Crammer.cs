using System;

namespace jonathan_s_crammer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a,b,c,d,e and f");//asks the user to input values for a,b,c,d,e,f
            double a,b,c,d,e,f;//declare the variables a,b,c,d,e,f
            a = Convert.ToDouble(Console.ReadLine());//initialize the variable a
            b = Convert.ToDouble(Console.ReadLine());//initialize the variable b
            c = Convert.ToDouble(Console.ReadLine());//initialize the variable c
            d = Convert.ToDouble(Console.ReadLine());//initialize the variable d
            e = Convert.ToDouble(Console.ReadLine());//initialize the variable e
            f = Convert.ToDouble(Console.ReadLine());//initialize the variable f
            double g = (a * d) - (b * c);//calculation for DETERMINANT
            double h = (e * d) - (b * f);//calculation for Determinant X
            double i = (a * f) - (e * c);//calculation for Determinant Y
            double x = h / g;//calculation for X
            double y = i / g;//calculation for Y
            if (g == 0)
            Console.WriteLine("the equation has no solution");
            else
            Console.Write("x is " + x);
            Console.WriteLine(" and y is " + y);
        
    }
}
}
