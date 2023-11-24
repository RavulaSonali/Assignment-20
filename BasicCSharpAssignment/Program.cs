using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1

            Console.WriteLine("Hello World \n");
            Console.ReadKey();

            //    //TASK 2

            Console.Write("Enter the Your name:\t");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Welcome\t" + name);
            Console.WriteLine("\n");
           

            //TASK 3

            int a;
         int b;
            
         Console.WriteLine("Enter the two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of " + a+ " and " + b+ "is: " +(a + b));
            Console.WriteLine("The difference of " + a + " and " + b + "is: " + (a - b));
            Console.WriteLine("The multiplication of " + a + " and " + b + "is: " + (a *b));
            if (b == 0)
            {
                Console.WriteLine("The result is undefined as 0 cannot be in denominator");
            }
            else 
            { 
                Console.WriteLine("The division of " + a + " and " + b + "is: " + (a / b));
                
            }
            if (b == 0)
            {
                Console.WriteLine("The result is undefined as 0 cannot be in denominator");
            }
            else
            {
                Console.WriteLine("The modulus of"+a+" and "+b+"is: " +(a%b));

            }


            Console.WriteLine("\n");

            //TASK 4

            int c;
            Console.WriteLine("Enter the integer");
            c = int.Parse(Console.ReadLine());
            if(c%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.WriteLine("\n");

            //TASK 5
            Console.WriteLine("Printing numbers from 1 to 10");
            int num = 0;
            while( num>11)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.WriteLine("\n");



            //TASK 6

            int[] arr= {1,2,3,4,5};
            int sum=0,avg=0;

            for (int i=0; i<5; i++)
            {
                sum = sum + arr[i];           

            }
            avg=sum/5;

            Console.WriteLine("The sum of the array is"+sum);
            Console.WriteLine("The average of the array is" + avg);
            Console.WriteLine("\n");

            //TASK 7

            Console.Write("Enter an integer to calculate its factorial: ");
            if (int.TryParse(Console.ReadLine(), out int factorialInput))
            {
                int CalculateFactorial(int n)
                {
                    if (n == 0)
                        return 1;
                    else
                        return n * CalculateFactorial(n - 1);
                }
                int result = CalculateFactorial(factorialInput);
                Console.WriteLine($"Factorial: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input for factorial calculation.");
            }
            Console.WriteLine("\n");


            //TASK 8
            int age;
            bool validAge = false;

            do
            {
                Console.Write("Enter your age: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    validAge = true;
                    if (age < 18)
                    {
                        Console.WriteLine("You are a minor.");
                    }
                    else if (age >= 18 && age <= 65)
                    {
                        Console.WriteLine("You are an adult.");
                    }
                    else
                    {
                        Console.WriteLine("You are a senior.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for age. Please enter a valid integer.");
                }
            } while (!validAge);
            Console.WriteLine("\n");

            Console.ReadKey();


        }
    }
}
