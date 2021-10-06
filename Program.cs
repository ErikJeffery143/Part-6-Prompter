using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_Prompter
{
    class Program
    {
        static void Main(string[] args)
        {

            int min;
            int max;
            int user;
            
            Console.WriteLine("Please Enter Your Minimum Value");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please Enter Your Maximum Value");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please Enter a Number Between " + min + " and " + max);
            user = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while ((user <= min) || (user >= max))
            {
                Console.WriteLine("That Wasnt a Number Between " + min + " and " + max);
                    Console.WriteLine("Please Enter a Number Between " + min + " and " + max);
                    user = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Congratulations");


            Console.ReadLine();

        }
    }
}
