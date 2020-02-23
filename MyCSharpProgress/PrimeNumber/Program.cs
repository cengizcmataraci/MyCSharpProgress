using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program //In this program we use a method, we have one 'for' block and two 'if' blocks. Also we have four variables; enteredNumber, number, result and i.
    {
        static void Main(string[] args)
        {
            int enteredNumber;  //The program wants to take a number from user
            Console.Write("Please enter a number: ");
            enteredNumber = Convert.ToInt32(Console.ReadLine()); //The entered number is originally a string type because of the fact that this line converting number to integer type.
            if (PrimeNumber(enteredNumber)) //The if block controls the entered number with the Prime Number method.
            {
                Console.WriteLine("The number {0} is prime.", enteredNumber); //If enteredNumber is a prime number, this line works.
            }
            else
            {
                Console.WriteLine("The number {0} is not prime.", enteredNumber); //If enteredNumber is not a prime number, this line works.
            }

            Console.ReadLine(); //This line provide not to close window after the enteredNumber is taken.
        }

        private static bool PrimeNumber(int number) //This method's purpose is to check the number is prime or not.
        {
            bool result = true; //The result is true at the beginning because the number accepted as a prime at the beginning.
            for (int i = 2; i < number - 1; i++) //In of the for loop, i variable equals to 2 at the beginning. And as i variable raise to number-1 (which is int variable capacity '-2 147 483 648 to 2 147 483 648')
            {
                if (number % i == 0) //This 'if' block provides to number variable divide to i variable and if the result is 0 then result variable turn to false. (which means the number is not prime.)
                {
                    result = false;
                    i = number; //This line's purpose; if the number is too large, it equals itself to the number in the for loop and the loop stops.
                }
            }

            return result; //If the result not changed, then returns the same position.
        }
    }
}
