using System;

namespace stories
{
    class Program
    {
        static void Main(string[] args)
 
        {

            Console.WriteLine(GetMax(2, 10));

            Console.ReadLine();




            bool isMale = true;
            bool isTall = false;


            if (isMale && isTall)

                {
                    Console.WriteLine("You are a tall male");
                } 
            
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            } 
            
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");

            }
            else

            { 
                Console.WriteLine("You are not male and not tall");
            }

            Console.ReadLine();
        }


        
      static int GetMax(int num1, int num2, num3)
        {

            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else 
            {
                result = num2;
            }

            return result;
        }
    }
}
