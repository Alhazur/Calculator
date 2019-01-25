using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stay = true;
            double num1;
            double num2;
            double num3;
            double svar;
            char oper;
            while (stay)
                try
                {
                    Console.WriteLine("Write number One");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Write number Two");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Choose oprator + - * /");
                    oper = Convert.ToChar(Console.ReadLine());



                    Console.Clear();


                    switch (oper)
                    {
                        case '+':
                            svar = plus(num1, num2); // kallar på plus metoden
                            Console.WriteLine("Result is " + svar);
                            break;
                        case '-':
                            svar = Minus(num1, num2);
                            Console.WriteLine("Result is " + svar);
                            break;
                        case '*':
                            svar = Multiplesera(num1, num2);
                            Console.WriteLine("Result is " + svar);
                            break;
                        case '/':
                            svar = Devidera(num1, num2);
                            Console.WriteLine("Result is " + svar);
                            break;
                        case 'e':
                            stay = false;
                            if (oper == 'e')
                            {
                                stay = false;
                                return;
                            }
                            break;

                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Not right number");
                    Console.WriteLine();
                }

            Console.ReadKey();

        }
        static double plus(double number1, double number2)
        {
            double svar = number1 + number2;
            Console.WriteLine("kak tam " + svar);

            Console.Write("Would you like to continue? y/n: ");
            string yesNo = Console.ReadLine();

            while (yesNo.Equals("y"))// när man jämför strings använd Equals method
            {
                Console.Write("+ ");
                double number3 = Convert.ToDouble(Console.ReadLine());
                svar = svar + number3;
                Console.WriteLine("Result " + svar);

                Console.Write("Would you like to continue? y/n: ");
                yesNo = Console.ReadLine();

            }

            return svar;
        }


        static double Minus(double number1, double number2)
        {
            double svar = number1 - number2;
            Console.WriteLine("kak tam " + svar);

            Console.Write("Would you like to continue? y/n: ");
            string yesNo = Console.ReadLine();

            while (yesNo.Equals("y"))// när man jämför strings använd Equals method
            {
                Console.Write("+ ");
                double number3 = Convert.ToDouble(Console.ReadLine());
                svar = svar - number3;
                Console.WriteLine("Result " + svar);

                Console.Write("Would you like to continue? y/n: ");
                yesNo = Console.ReadLine();

            }

            return svar;
        }
        static double Multiplesera(double number1, double number2)
        {
            return number1 * number2;
        }
        static double Devidera(double number1, double number2)
        {
            if (number2 == 0)
            {
                Console.WriteLine("dumt");
                return 0;
            }
            else
            {
                return number1 / number2;
            }


        }

    }
}