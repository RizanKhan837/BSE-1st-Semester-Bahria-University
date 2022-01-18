using System;
using System.IO;

namespace Computer_Programming_Tasks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Task 2

            /*
           Console.WriteLine(3.0 * 5.0);
           Console.WriteLine(7.1 * 8.3 - 2.2);
           Console.WriteLine("{0:0.000}",3.2/(6.1*5));
           Console.WriteLine(15.0/4.0);
           Console.WriteLine(15%4);
           Console.WriteLine((5*3) - (6*4));
           Console.ReadLine();
           */

            /*   //Fahrenheit to Celsius
           double c, f;
           Console.Write("Input Temperature in Fahrenheit: ");
           f = Convert.ToDouble(Console.ReadLine());
           c = (double)5 /(double) 9 * (f - 32);
           Console.WriteLine("Temperatur in Celsius is {0:0.00}°C", c);
            */

            //Area Of a Circle
            /*

            double Area, radius;
            const double pie = 3.142;
            Console.WriteLine("Input Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Area = pie * (radius * radius);
            Console.WriteLine("Area Of a Circle is {0}", Area);
            Console.ReadLine();

           */

            //First Equation Of Motion

            /*
            double Vf, Vi, acc, time;
            Console.Write("Input Initial Velocity: ");
            Vi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Aceleration: ");
            acc = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Time: ");
            time = Convert.ToDouble(Console.ReadLine());
            Vf = Vi + (acc * time);
            Console.WriteLine("Final Velocity Is {0:0.00} m/s²  ", Vf );
            Console.ReadLine();
            */

            //2nd Equation Of Motion

            /*
            double Vf, Vi, a, t;
            Console.WriteLine("Input Initial Velocity: ");
            Vi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Aceleration: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Time: ");
            t = Convert.ToDouble(Console.ReadLine());
            Vf = ((Vi * t) + (0.5 * a *(t*t)));
            Console.WriteLine("The Final Velocity is {0}", Vf);
            Console.ReadLine();
            */

            /*  //Force

            double m, f;
            const double a = 9.8;
            Console.WriteLine("Enter he Value Of Mass: ");
            m = Convert.ToDouble(Console.ReadLine());
            f = m * a;
            Console.WriteLine("The Value Of Force is: " + f);

            */

            //Pythagorus Theorem Formula

            /*
            double a, b, c;
            Console.WriteLine("Input a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input a: ");
            b = Convert.ToDouble(Console.ReadLine());
            c = (a*a) + (b*b);
            Console.WriteLine(Math.Sqrt(c));
            Console.ReadLine();
            */

            //Display the Result of the Expression

            /*
            double a=1, b=2, c=2, d=1, e=1, f=2;

            double Answer = (((a + b) * (c * e * d)) - e) / (double)f;

            Console.WriteLine("The Answer Of The Equation is {0}", Answer);

            Console.ReadLine();

            */

            /*
            double a, b, c, d, e, f;
            Console.Write("Input a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input c: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input d: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input e: ");
            e = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input f: ");
            f = Convert.ToDouble(Console.ReadLine());

            double Answer = (((a + b) * (c * e * d)) - e) / (double)f;
            Console.WriteLine("The Answer Of The Equation is {0}", Answer);
            Console.ReadLine();
            */

            /*

            Console.WriteLine("Enter Your First Name: ");
            string Name1 = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            string Name2 = Console.ReadLine();
            Console.WriteLine("Enter Your Father Name: ");
            string fatherName = Console.ReadLine();
            Console.WriteLine("Enter Your Age: ");
            long age = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Your Phone No. : ");
            long phNum = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Your Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Your Education: ");
            string edu = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("--------Profile Information--------\n");
            Console.WriteLine("|First Name: " + Name1 + "               |");
            Console.WriteLine("|Last Name: " + Name2 + "                 |");
            Console.WriteLine("|Father Name: " + fatherName + "      |");
            Console.WriteLine("|Age: " + age + "                          |");
            Console.WriteLine("|Phone No.: " + phNum + "            |");
            Console.WriteLine("|Email : " + email + "   |");
            Console.WriteLine("|Education : " + edu + "                |");
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

            */

            // Task 3

            /*
            int num = 123, num1 = 456;
            Console.WriteLine("{0, 5},{1,5}\n", num, num1);   //RIGHT ALLIGNMENT
            Console.WriteLine("{0,-5},{1,-5}\n", num, num1);   //LEFT ALLIGNMENT
            Console.WriteLine("{0,-5:D6},{1,-5:D6}", 123, 456); // D6 Means 6 Decimal Digits
            Console.ReadLine();
            */

            /*

            int i= 123456;
            Console.WriteLine("{0:C}", i);
            Console.WriteLine("{0:D}", i);
            Console.WriteLine("{0:E}", i);
            Console.WriteLine("{0:F}", i);
            Console.WriteLine("{0:G}", i);
            Console.WriteLine("{0:N}", i);
            Console.WriteLine("{0:P}", i);
            Console.WriteLine("{0:X}", i);
            /*

            /*
            Console.WriteLine("Three Decimal Places");
            Console.WriteLine(String.Format("{0:0.000}", 765.456));
            Console.WriteLine(String.Format("{0:0.000}", 765.45));
            Console.WriteLine(String.Format("{0:0.000}\n", 765.45465));
            Console.WriteLine("Thousand Separator");
            Console.WriteLine(String.Format("{0:0,0.0}", 765.456));
            Console.ReadLine();
            */

            /*
            DateTime datetime = DateTime.Now;
            Console.WriteLine("Enter Your First Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Father Name: ");
            string fatherName = Console.ReadLine();
            Console.WriteLine("Enter Your Phone No. : ");
            long phNum = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Your Designation: ");
            string Design = Console.ReadLine();
            Console.WriteLine("Enter Date Of Hiring (e.g. 17/2/1987): ");
            string date = Console.ReadLine();
            Console.WriteLine("Enter Your Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------Profile Information--------\n");
            Console.WriteLine("|First Name: {0}           \t|",name);
            Console.WriteLine("|Father Name: {0}          \t|",fatherName);
            Console.WriteLine("|Phone No.: {0:(+##) ###-#######}  \t|",phNum);
            Console.WriteLine("|Designation: {0}       \t|",Design);
            Console.WriteLine("|Date Of Hiring: {0:dd/MM/yy}    \t|",date);
            Console.WriteLine("|Salary: {0:C}    \t\t|",salary);
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();
            */

            //Task 04

            /*
            Console.WriteLine("     Pythagorus Theorem     \n");
            double a, b, c, C_square;
            Console.Write("Input a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input b: ");
            b = Convert.ToDouble(Console.ReadLine());
            C_square = Math.Pow(a , 2) + Math.Pow(b , 2);
            c = Math.Sqrt(C_square);
            Console.WriteLine("The value of \"C\" is {0:0.00}", c);
            Console.ReadLine();

            */

            /*

            Console.WriteLine("           Arithmatical Operation          \n");

            int num1, num2;
            Console.Write("Input a Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n1) Addition");
            Console.WriteLine("Addition of {0} and {1} is {2}\n", num1, num2, num1 + num2);

            Console.WriteLine("2) Subtraction");
            Console.WriteLine("Subtraction of {0} and {1} is {2}\n", num1, num2, num1 - num2);

            Console.WriteLine("3) Multiplication");
            Console.WriteLine("Multiplication of {0} and {1} is {2}\n", num1, num2, num1 * num2);

            Console.WriteLine("4) Division");
            Console.WriteLine("Division of {0} and {1} is {2}\n", num1, num2, num1 / num2);

            Console.WriteLine("5) Modulus ");
            Console.WriteLine("Modulus of {0} and {1} is {2}\n", num1, num2, num1 % num2);

            Console.ReadLine();

            */

            /*
             Console.WriteLine("             BitWise Operation             \n");
             int num1, num2;
             Console.Write("Input a Number: ");
             num1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input a Second Number: ");
             num2 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("\nAND OPERATOR = {0}", num1 & num2);
             Console.WriteLine("OR OPERATOR = {0}", num1 | num2);
             Console.WriteLine("XOR OPERATOR = {0}", num1 ^ num2);
             Console.ReadLine();
            */

            //Console.WriteLine("             Logical Operators             ");
            //bool a = true, b = false;
            //Console.WriteLine("{0}", a && b);
            //Console.WriteLine("{0}", a || b);
            //Console.WriteLine("{0}", a ^ b);
            //Console.ReadLine();

            // Task 05

            //Even & Odd

            /*
            double num;
            Console.WriteLine("Enter a No. :");
            num = Convert.ToDouble(Console.ReadLine());
            if (num %2 ==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            double num; string result;
            Console.Write("Enter a No. : ");
            num = Convert.ToDouble(Console.ReadLine());
            result = (num % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
            Console.ReadLine();

            */

            // Guessing GAME
            /*
            int secretNumber = 8;
            int guessInput;
            string input;
            Console.WriteLine("Do You Want To Play \"Guessing Game\" (Y)es or (N)o");
            input = Console.ReadLine();
            if (input == "Y" || input == "y")
            {
                int age;
                Console.WriteLine("\n\t\t Guessing Secret No");
                Console.Write("Enter Your Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if(age > 6)
                {
                    Console.Write("Enter any number: ");
                    guessInput = Convert.ToInt32(Console.ReadLine());
                    if(guessInput == secretNumber)
                        Console.WriteLine("You have successfully guessed the secret number...");
                    else
                        Console.WriteLine("You were not successful in guessing the secret number...");
                }
                else
                    Console.WriteLine("You are too young to play...");
            }
            else
                Console.WriteLine("Maybe Next Time...^_^");
            Console.ReadLine();

            */

            //Vowel Check
            /*
             string input;
            Console.Write("Input an Alphabet: ");
            input = Console.ReadLine();
            switch (input)
            {
                case "a": case "e":
                case "i": case "o":
                case "u":
                    Console.WriteLine("Its a Vowel");
                    break;

                default:
                    Console.WriteLine("Its not Vowel");
                    break;
            }
            Console.ReadLine();

             */

            // Bahria Check In

            /*
            DateTime dt = DateTime.Now;
            string input, name, department, enrollment, CNIC;
            Console.WriteLine("Select any Option! ");
            Console.WriteLine("a) Bahrian");
            Console.WriteLine("b) Alumnia");
            Console.WriteLine("c) Outsiders");
            Console.WriteLine("d) Exit");
            input = Console.ReadLine();

            if (input == "a" || input == "A")
            {
                Console.Write("Enter Your Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Your Enrollment No. : ");
                enrollment = Console.ReadLine();
                Console.Write("Enter Your Department : ");
                department = Console.ReadLine();
                Console.WriteLine("\n\t\t BAHRIA CHECK IN SYSTEM\n");
                Console.WriteLine("Created By: Rizwan Akram  \t {0}\n", dt);
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Enrollment: {0}", enrollment);
                Console.WriteLine("Department: {0}", department);
            }
            else if (input == "b" || input == "B")
            {
                Console.Write("Enter Your Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Your CNIC No. : ");
                CNIC = Console.ReadLine();
                Console.Write("Enter Your Department : ");
                department = Console.ReadLine();
                Console.WriteLine("\n\t\t BAHRIA CHECK IN SYSTEM\n");
                Console.WriteLine("Created By: Rizwan Akram  \t\t {0}\n", dt);
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("CNIC: {0}", CNIC);
                Console.WriteLine("Department: {0}", department);
            }
            else if (input == "c" || input == "C")
            {
                Console.Write("Enter Your Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Your CNIC No. : ");
                CNIC = Console.ReadLine();
                Console.WriteLine("\n\t\t BAHRIA CHECK IN SYSTEM\n");
                Console.WriteLine("Created By: Rizwan Akram  \t\t {0}\n", dt);
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("CNIC: {0}", CNIC);
            }
            else if (input == "d" || input == "D")
                Environment.Exit(0);
            else
                Console.WriteLine("You Input a Wrong Option...!!!");
            Console.ReadLine();
            */

            //Calculator

            /*
            string input;
            Console.WriteLine("Calculator");
            Console.WriteLine("Which Opertaion You Want To Perform: ");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Division");
            Console.WriteLine("4) Multiplication");
            Console.WriteLine("5) Modulus");
            input = Console.ReadLine();

            double num1, num2;
            switch (input)
            {
                case "1":
                    Console.WriteLine("\nYou Chose Addition");
                    Console.Write("Input a No. : ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input another No. : ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Addition of {0} and {1} is {2}", num1, num2, num1 + num2);
                    break;

                case "2":
                    Console.WriteLine("\nYou Chose Subtraction");
                    Console.Write("Input a No. : ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input another No. : ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Subtraction of {0} and {1} is {2}", num1, num2, num1 - num2);
                    break;

                case "3":
                    Console.WriteLine("\nYou Chose Division");
                    Console.Write("Input a No. : ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input another No. : ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Division of {0} and {1} is {2}", num1, num2, num1 / num2);
                    break;

                case "4":
                    Console.WriteLine("\nYou Chose Multiplication");
                    Console.Write("Input a No. : ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input another No. : ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Multiplication of {0} and {1} is {2}", num1, num2, num1 * num2);
                    break;

                case "5":
                    Console.WriteLine("\nYou Chose Modulus");
                    Console.Write("Input a No. : ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input another No. : ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Modulus of {} and {} is {}", num1, num2, num1 % num2);
                    break;

                default:
                    Console.WriteLine("You Input a Wrong Option...!!");
                    break;
            }

            Console.ReadLine();

            */

            // Lab 06

            /*
             for (int small = 1, large = 10; small < large; small++, large--)
             {
                 Console.WriteLine("{0} {1}",small,large);
             }
            */

            /*
            int n = 100, sum = 0;
            for (int i = 1; i <= n; i+=2)
            {
                if (i % 7 == 0)
                {
                    continue;
                }
                sum ++;
            }
            Console.WriteLine(sum);

            */
            /*for (int i = 1; i < 14; i+=2)
            {
                Console.WriteLine("Cube Of {0} is {1}",i, i*i*i);
            }

            // Cube Series

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Cube Of {0} is {1}", i, i * i * i);
            }

            // Square Series

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Square Of {0} is {1}", i,  i * i);
            }
            Console.ReadLine();
             */

            /*
            Console.Write("Input a Number: ");
            double num = double.Parse(Console.ReadLine());
            for (double i = num; i >0 ; i -= 0.5)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            // Sqrt Of First 25 Odd Integers

            /* for (int i = 1, num = 1; i < 50; i+=2, num++)
             {
                 Console.WriteLine("{0}) √{1} = {2:0.00} ",num , i, Math.Sqrt(i));
             }
             Console.ReadLine();

             */

            // Guessing Game

            /*int input, secretNum = 8, guessCount = 0;
            Console.WriteLine("Guessing Game!! \n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Guess a Secret No. : ");
                input = int.Parse(Console.ReadLine());
                guessCount++;
                if (input == secretNum)
                {
                    Console.WriteLine("Correct!!");
                    Console.WriteLine("It Took You {0} Guesses To Guess a Secret Number...", guessCount);
                    break;
                }
                else
                    Console.WriteLine("Wrong!!...");
            }
            Console.ReadLine();*/

            /*for (int i = 1; i < 10; i++)
            {
                for (int m = 0; m < i; m++)
                {
                    Console.Write("* " );
                }
                Console.WriteLine();
            }*/

            /* int num = 0;

             for (int i = 9; i > num; i--)
             {
                 for (int m = 1; m < i; m++)
                 {
                     Console.Write(" *");
                 }
                 Console.WriteLine();
             }*/

            /*int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i);
                for (int j = i + 1; j < num - i + 1 ; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }*/

            // Building a Matrix

            /*Console.Write("Input The No. Of Matrix: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write("| " + i + " | ");
                for (int m = 1 + i; m <= num + i - 1; m++)
                {
                    Console.Write(m + " | ");
                }
                Console.Write("\n");
            }*/

            // Lab 07

            //   Task 3

            /*int num1 = 0, num2 = 1, input, sum;
            Console.Write("Enter The Length Of The Series : ");
            input = int.Parse(Console.ReadLine());
            Console.Write("\n {0} {1}",num1,num2);
            for (int i = 0; i < input - 1; i++)
            {
                sum = num1 + num2;
                Console.Write(" " + sum);
                num1 = num2;
                num2 = sum;
            }*/

            /*  int a = 0, b = 1, num = 1, c, length;
              Console.Write("Input The Length Of The Series: ");
              length = int.Parse(Console.ReadLine());
              Console.Write("\n {0} {1}", a, b);
              while (num < length - 1)
              {
                  c = a + b;
                  Console.Write(" " + c);
                  a = b;
                  b = c;
                  num++;
              }
              Console.ReadLine();*/

            //  Task 02

            /*double x;
            Console.Write("Enter Value Of X: ");
            x = double.Parse(Console.ReadLine());
            while (x > 0)
            {
                Console.WriteLine("{0}", x);
                x -= 0.5;
            }
            Console.ReadLine();*/

            // Task 01

            /*
            double m = 1;
            int num = 1;
            while (m < 50)
            {
                Console.WriteLine("{0,3}) SQRT OF {1} IS {2:0.00}",num , m, Math.Sqrt(m));
                num++;
                m += 2;
            }
            Console.ReadLine();
            */

            /*int n, i, j, k, l, num;
            Console.Write("Input number of rows for this pattern :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of rows for this pattern :");
            num = Convert.ToInt32(Console.ReadLine());
            for (k = num; k >= 0; k--)
            {
                for (l = 0; l < num - k; l++)
                {
                    Console.Write(" ");
                }
                for (l = 0; l < 2 * k - 1; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int m = 0; m < 5; m++)
            {
                Console.WriteLine("       ***");
            }*/

            //   To Calculate Factorial Of a Number...

            /* int result, i, num;
             Console.Write("Enter a Number: ");
             result = int.Parse(Console.ReadLine());
             num = result;
             for (i = result - 1; i > 0; i--)
             {
                 result *= i;
             }
             Console.WriteLine("Factoria of {0} is {1}", num, result);*/

            /* int num1;
             Console.Write("Enter a Number: ");
             num1 = int.Parse(Console.ReadLine());
             int j = num1 - 1;
             while (j > 0)
             {
                 num1 *= j;
                 j--;
             }
             if (num1 > 0)
             {
                 Console.WriteLine(num1);
             }
             else
             {
                 Console.WriteLine(1);
             }*/

            /*int num1;
            Console.Write("Enter a Number: ");
            num1 = int.Parse(Console.ReadLine());
            int j = 1;
            do
            {
                j *= num1;
                num1--;
            } while (num1 > 0);

            Console.WriteLine(j);*/

            // Lab 9

            // Task 1

            /*int[] elements;
            int i, num, count;
            Console.WriteLine("Enter No. Of Elements");
            num = int.Parse(Console.ReadLine());
            elements = new int[20];
            for (i = 0; i < num; i++)
                elements[i] = i * 5;
            Console.WriteLine("The Elements Of The Array Are ");
            for (i = 0, count = 0; i < elements.Length; i++, count++)
                Console.WriteLine("5 * {0}  = {1}", count, elements[i]);
            Console.ReadLine();*/

            // Task 2

            /* int[] array1, array2;
             int i, size1, size2;
             bool areEqual = false;
             Console.Write("Enter Size Of Array 1 : ");
             size1 = int.Parse(Console.ReadLine());
             Console.Write("Enter Size Of Array 2 : ");
             size2 = int.Parse(Console.ReadLine());
             array1 = new int[size1];
             array2 = new int[size2];
             Console.WriteLine();
             for (i = 0; i < size1; i++)
             {
                 Console.Write("Enter Values Of \"Array 1\" Of Index {0} : ", i);
                 array1[i] = int.Parse(Console.ReadLine());
             }
             Console.WriteLine();
             for (i = 0; i < size2; i++)
             {
                 Console.Write("Enter Values Of \"Array 2\" Of Index {0} : ", i);
                 array2[i] = int.Parse(Console.ReadLine());
             }
             for (i = 0; i < array1.Length; i++)
             {
                 if (array1[i] == array2[i])
                 {
                     areEqual = true;
                 }
                 else
                 {
                     areEqual = false;
                 }
             }
             Console.WriteLine("\nBoth Arrays Are Equal? = {0} ", areEqual);*/

            // Task3

            /*int[] num = new int[5];
            double average = 0;
            int i, cnt, total = 0;
            for (i = 0, cnt = 0; i < 5; i++, cnt ++)
            {
                Console.Write("Enter Values Of Array Of Index {0}: ", cnt);
                num[i] = int.Parse(Console.ReadLine());
                total += num[i];
            }
            for (i = 0; i < num.Length; i++)
            {
                average = total / 5;
            }
            Console.WriteLine("Sum Of Array Is {0}",total);
            Console.WriteLine("Average Of The Array is {0}", average);
            Console.ReadLine();*/

            // ASSIGNMENT # 01

            // Q: 1
            /*int i, j, k, num;
            Console.Write("Enter Number Of Rows For This Pattern: ");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i)
                        k = 1;
                    else
                        k = 0;
                    Console.Write(k + " ");
                }
                Console.Write("\n");
            }*/

            // Q: 2

            /*int age;
            Console.Write("Enter Your Age: ");
            age = int.Parse(Console.ReadLine());
            age += 10;
            Console.WriteLine("Your Age After Ten Years Will Be {0}", age);*/

            // Q: 3

            /*double a, b, height, area;
            Console.WriteLine("     \"Area Of Trapezoid\"       ");
            Console.Write("Enter Value Of a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter Value Of b : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter Height : ");
            height = double.Parse(Console.ReadLine());
            area = 0.5 * (a + b) * height;
            Console.WriteLine("Area of Trapezoid is {0}m²", area);*/

            // Q: 4

            /*int num1, num2, num3, num4, sum, input;
            Console.Write("Enter a 4-Digit Number :");
            input = int.Parse(Console.ReadLine());

            num1 = (input / 1000) % 10;
            num2 = (input / 100) % 10;
            num3 = (input / 10) % 10;
            num4 = (input / 1) % 10;
            Console.WriteLine("Numbers In Reversed Order : {3}{2}{1}{0}", num1, num2, num3, num4);
            Console.WriteLine("Placing Last Digit In First Position : {3}{0}{1}{2}", num1, num2, num3, num4);
            Console.WriteLine("Exchanging Second & Third Position : {0}{2}{1}{3}", num1, num2, num3, num4);
            Console.WriteLine("Sum Of The Digit Is {0}", num1 + num2 + num3 + num4);*/

            // Q: 5

            /*int[] age, employeeNum;
            char[] gender;
            int num; string reply;
            string[] First_Name, Last_Name, Data;
            int employee = 1;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter The No. Of Employees : ");
                num = int.Parse(Console.ReadLine());
                age = new int[num];
                employeeNum = new int[num];
                gender = new char[num];
                First_Name = new string[num];
                Last_Name = new string[num];
                Data = new string[num];
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("------------ Employee {0} ------------", employee);
                    Console.Write("\nEnter The First Name Of The Employee : ");
                    First_Name[i] = Console.ReadLine();
                    Console.Write("Enter The Last Name Of The Employee : ");
                    Last_Name[i] = Console.ReadLine();
                    Console.Write("Enter Employee's Gender ( m/f ): ");
                    gender[i] = char.Parse(Console.ReadLine());
                    Console.Write("Enter Employee's Age : ");
                    age[i] = int.Parse(Console.ReadLine());
                    Console.Write("Enter Employee's Number (4220001-4229999): ");
                    employeeNum[i] = int.Parse(Console.ReadLine());
                    employee++;
                    Data[i] = $"------------Employee Info-------------------" +
                        $"\nFirst Name       |       {First_Name[i] } " +
                        $"\nLast Name        |       {Last_Name[i]} " +
                        $"\nGender           |       {gender[i]}" +
                        $"\nAge              |       {age[i]}" +
                        $"\nEmployee Number  |       {employeeNum[i]}" +
                        $"\n----------------------------------------";
                }
                foreach (string data in Data)
                {
                    Console.Clear();
                    Console.WriteLine(data);
                    Console.ReadLine();
                }
                Console.Write("Do You Want To Restart Application? : ");
                reply = Console.ReadLine();
            } while (reply == "yes" || reply == "y");*/

            // Q: 6

            /*int digit;
            Console.Write("Input Digit(0-9) : ");
            digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 0:
                    Console.Write("Zero\n"); break;
                case 1:
                    Console.Write("one\n"); break;
                case 2:
                    Console.Write("Two\n"); break;
                case 3:
                    Console.Write("Three\n"); break;
                case 4:
                    Console.Write("Four\n"); break;
                case 5:
                    Console.Write("Five\n"); break;
                case 6:
                    Console.Write("Six\n"); break;
                case 7:
                    Console.Write("Seven\n"); break;
                case 8:
                    Console.Write("Eight\n"); break;
                case 9:
                    Console.Write("Nine\n"); break;
                default:
                    Console.Write("Invalid No. !!!");
                    break;
            }*/

            // Q: 7

            /*double sell, cost, amount;
            Console.Write("Input Cost Price : ");
            cost = double.Parse(Console.ReadLine());
            Console.Write("Input Selling Price : ");
            sell = double.Parse(Console.ReadLine());
            amount = sell - cost;
            Console.Write("\n");
            if (amount >= 0)
                Console.WriteLine("Seller Has Made Profit Of {0} Rupees", amount);
            else
                Console.WriteLine("Seller Had a Loss Of {0} Rupees", amount * (-1));*/

            // Q: 8

            /*int ang1, ang2, ang3, sum;
            Console.Write("Input angle a : ");
            ang1 = int.Parse(Console.ReadLine());
            Console.Write("Input angle b : ");
            ang2 = int.Parse(Console.ReadLine());
            Console.Write("Input angle c : ");
            ang3 = int.Parse(Console.ReadLine());
            sum = ang1 + ang2 + ang3;
            if (sum == 180)
                Console.WriteLine("The triangle is valid.\n");
            else
                Console.WriteLine("The triangle is not valid.\n");*/

            // Q: 9

            /*int[] array;
            int i, size, max = 0, min = 0;
            Console.Write("Enter Size Of an Array : ");
            size = int.Parse(Console.ReadLine());
            array = new int[size];
            Console.Write("\n");
            for (i = 0; i < size; i++)
            {
                Console.Write("Input Value Of Index {0} : ", i);
                array[i] = int.Parse(Console.ReadLine());
                min = array[0];
                max = array[0];
            }
            for (i = 0; i < size; i++)
            {
                if (array[i] >= max)
                    max = array[i];
                if (array[i] <= min)
                    min = array[i];
            }
            Console.Write("\n");
            Console.WriteLine("Maximum Element = {0}", max);
            Console.WriteLine("Minimum Element = {0}", min);*/

            // Q: 10

            /*int[] array;
            int i, size, num, pos = 0;
            bool isExist = false;
            Console.Write("Enter Size Of an Array : ");
            size = int.Parse(Console.ReadLine());
            array = new int[size];
            Console.Write("\n");
            for (i = 0; i < size; i++)
            {
                Console.Write("Input Value Of Index {0} : ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Input a Number: ");
            num = int.Parse(Console.ReadLine());
            for (i = 0; i < size; i++)
            {
                if (num == array[i])
                {
                    isExist = true;
                    pos = i;
                    break;
                }
                else
                    isExist = false;
            }
            if (isExist == true)
                Console.WriteLine("\n{0} Is Found At Postion {1}", num, pos);
            else
                Console.WriteLine("\n{0} Doesn't Exist In The ArraY", num);*/

            //  Lab 10
            // Task 1:

            /*int i, j;
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] add = new int[3, 3];
            int[,] sub = new int[3, 3];
            Console.WriteLine("-------Array 1-------");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"Enter Values Of [{i},{j}] : ");
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("-------Array 2-------");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"Enter Values Of [{i},{j}] : ");
                    array2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("-----------Addition----------");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    add[i, j] = array1[i, j] + array2[i, j];
                    Console.Write("     {0} ",add[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------Subtraction----------");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    sub[i, j] = array1[i, j] - array2[i, j];
                    Console.Write("     {0} ", sub[i, j]);
                }
                Console.WriteLine();
            }*/

            //Task 2

            /*int i, j;
            string[] eyeColor = { "Brown", "Green", "Blue", "Gray", "Hazel" };
            string[] data = { "Name: ", "Nationality: ", "Eye Color : " };
            string[,] UserData = new string[11, 3];
            int[] count = new int[5];

            Console.WriteLine("**********Enter User Details**********\n");
            for (i = 0; i < UserData.GetLength(0); i++)
            {
                for (j = 0; j < UserData.GetLength(1); j++)
                {
                    Console.Write("Enter {0}", data[j]);
                    UserData[i, j] = Console.ReadLine();
                }
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("-----------Peoples With Different Eye Colors-----------");
            for (i = 0; i < UserData.GetLength(0); i++)
            {
                for (j = 0; j < eyeColor.Length; j++)
                {
                    if (UserData[i, 2] == eyeColor[j])
                    {
                        count[j]++;
                    }
                }
            }
            for (i = 0; i < eyeColor.GetLength(0); i++)
            {
                Console.WriteLine($"{eyeColor[i]} = {count[i]}");
            }*/

            // Task 3

            /*int i, j, count, items;
            string[] Total_discount = new string[3];
            string[] Items = { "Name Of Item : ", "Quantity Of Item (In KG): ", "Price Of Item / KG: " };
            double[] Price = new double[3];
            double[] Quantity = new double[3];
            double Discount ;
            double Total = 0;
            Console.Write("Enter No. Of Items : ");
            items = int.Parse(Console.ReadLine());
            string[,] Input = new string[items, 3];
            for (i = 0, count = 1; i < Input.GetLength(0); i++, count++)
            {
                Console.WriteLine("Enter Item No. {0}", count);
                for (j = 0; j < Input.GetLength(1); j++)
                {
                    Console.Write($"{Items[j]}");
                    Input[i, j] = Console.ReadLine();
                    Quantity[i] = Convert.ToDouble(Input[i, 1]);
                    Price[i] = Convert.ToDouble(Input[i, 2]);
                    Total += Price[i] * Quantity[i];
                    if (Input[i, 0] == "Rice")
                    {
                        Total_discount[i] = "30%";
                        Discount = Total * 0.3;
                        Total -= Discount;
                    }
                    else
                    {
                        Total_discount[i] = "0%";
                        Discount = Total * 0.0;
                        Total -= Discount;
                    }
                }
                Console.Write("\n");
            }
            for (i = 0; i < Input.GetLength(0); i++)
            {
                if (Total >= 50000 && Total <= 100000)
                {
                    Total_discount[i] = "20%";
                    Discount = Total * 0.2;
                    Total -= Discount;
                }
                else if (Total > 100000)
                {
                    Total_discount[i] = "30%";
                    Discount = Total * 0.3;
                    Total -= Discount;
                }
            }
            Console.Clear();
            for (i = 0; i < Input.GetLength(0); i++)
            {
                Console.WriteLine("Name = {0}", Input[i, 0]);
                Console.WriteLine("Quantity = {0}", Input[i, 1]);
                Console.WriteLine("Price = Rs. {0:N}", Input[i, 2]);
                Console.WriteLine("Dicount = {0}", Total_discount[i]);
                Console.Write("\n");
            }
            Console.WriteLine("Total = Rs. {0:N} \n", Total);*/

            // Lab 10

            //TASK 1

            /*int num;
            Console.Write("Enter Any Number : ");
            num = int.Parse(Console.ReadLine());
            Square_Cube(num);*/

            // Task 2
            /*int table_num, start, end;
            Console.Write("Enter Table Number : ");
            table_num = int.Parse(Console.ReadLine());
            Console.Write("Enter Starting Point Of The Table : ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter Ending Point Of The Table : ");
            end = int.Parse(Console.ReadLine());
            Table(table_num, start, end);
            Console.ReadLine();*/

            // Task 3

            /*int i;
            int[] array = new int[] { 1, 5, 8, 3, 7 };
            Console.Write("\n");
            Console.WriteLine("Max Number In This Array Is {0}", Max(array));
            Console.WriteLine("Min Number In This Array Is {0}", Min(array));*/

            // Task 4

            /*int[] array = new int[6];
            arrayInput(array);
            reverseArray(array);*/

            // Task 5

            //RunCalculator();

            // Task 6
            /*Program program = new Program();
            program.Marksheet();*/

            // Lab 12

            // Task 1
            /*AddUserData();
            var path = @"D:\UserData.txt";
            Reader(path);

            // Task 2
            Menu();*/

            // Lab 13

            // Task 1
            /*try
            {
                Console.Write("Enter a Number : ");
                double Num = double.Parse(Console.ReadLine());
                if (Num >= 0)
                {
                    Console.WriteLine("SquareRoot Of {0} is {1}", Num, Math.Sqrt(Num));
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Good Bye");
            }*/

            // Task 2


            /*try
            {
                int[] array = new int[10];
                arrayInput(array);
                ReadNumber(array, 3, 5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/

            // Task 3

            /*Reader("D:\\File.txt");

            Writing();*/



            Console.ReadLine();
        }

        private static void Square_Cube(int num)
        {
            Console.WriteLine("Square Of This Number Is {0}", num * num);
            Console.WriteLine("Cube Of This Number Is {0}", num * num * num);
        }

        private static void Table(int table_num, int start, int end)
        {
            int i;
            Console.Write("\n");
            Console.WriteLine("**********Table***********");
            Console.WriteLine("==========================");
            for (i = start; i <= end; i++)
                Console.WriteLine("{0} x {1} = {2}", table_num, i, table_num * i);
        }

        private static int Max(int[] array)
        {
            int i, max;
            max = array[0];
            for (i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            return max;
        }

        private static int Min(int[] array)
        {
            int i, min;
            min = array[0];
            for (i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }
            return min;
        }

        private static void arrayInput(int[] array)
        {
            int i;
            for (i = 0; i < array.Length; i++)
            {
                Console.Write("Enter Element [{0}] : ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        private static void reverseArray(int[] array)
        {
            int i;
            Console.Write("Reversed Array = {");
            for (i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($" {array[i]},");
            }
            Console.Write(" }");
        }

        private static void RunCalculator()
        {
            string oprType;
            double num1, num2;
            try
            {
                Console.Clear();
                Console.WriteLine("------------Calculator-----------\n");
                Console.Write("Enter a Number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter a Another Number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Which Type Of Calculations You Want To Perform? ");
                Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Modulus");
                oprType = Console.ReadLine();
                if (oprType == "1")
                {
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                    restart();
                }
                else if (oprType == "2")
                {
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                    restart();
                }
                else if (oprType == "3")
                {
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
                    restart();
                }
                else if (oprType == "4")
                {
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                    restart();
                }
                else if (oprType == "5")
                {
                    Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2);
                    restart();
                }
                else
                {
                    Console.WriteLine("Invalid No. !!");
                    restart();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                restart();
            }
        }

        private static void restart()
        {
            string playAgain;
            Console.WriteLine("Do You Want To Restart Calculator? If Yes Press 'y'... ");
            playAgain = Console.ReadLine();
            do
            {
                RunCalculator();
            } while (playAgain == "y" || playAgain == "Y");
        }

        private string[] Input = { "Name : ", "Class : ", "Section : ", "Enrollment No. : " };
        private string[] Bio = new string[4];
        private string[] Subjects = { "Computer Programming", "Computing Fundamentals", "English", "Physics", "Applied Calcululus" };
        private double[] Marks = new double[5];
        private string[] Data = new string[9];
        private int i;

        public void Marksheet()
        {
            Console.WriteLine("************Student Info**********");
            Console.WriteLine("__________________________________");
            inputData();
            Console.WriteLine("*************MarkSheet************");
            Console.WriteLine("__________________________________");
            output();
        }

        public void inputData()
        {
            for (i = 0; i < Input.Length; i++)
            {
                Console.Write("Input Your {0}", Input[i]);
                Bio[i] = Console.ReadLine();
            }
            Console.Write("\n");
            for (i = 0; i < Subjects.Length; i++)
            {
                Console.Write("Input Your {0} Marks : ", Subjects[i]);
                Marks[i] = double.Parse(Console.ReadLine());
            }
        }

        public void output()
        {
            Console.Clear();
            Data[i] = $"------------Marksheet----------------------" +
                        $"\nName             |       {Bio[0] }     " +
                        $"\nClass            |       {Bio[1] }     " +
                        $"\nSection          |       {Bio[2] }     " +
                        $"\nEnrollment No.   |       {Bio[3] }     " +
                        $"\n_______________________________________" +
                        $"\nSubject          |       Marks Obtained" +
                        $"\nCP Marks         |       {Marks[0]}    " +
                        $"\nCF Marks         |       {Marks[1]}    " +
                        $"\nEnglish Marks    |       {Marks[2]}    " +
                        $"\nPhysics  Marks   |       {Marks[3]}    " +
                        $"\nApplied Calculus |       {Marks[4]}    " +
                        $"\n----------------------------------------";
            for (i = 0; i < Data.Length; i++)
            {
                Console.Write(Data[i]);
            }
        }

        //      Lab 12

        private static void AddUserData()
        {
            string Name, DOB, Email, Address, Job_Title;
            int Salary, Employee_Id;
            try
            {
                Console.WriteLine(" ----------User Data---------");
                Console.Write("\n");
                Console.Write("Enter Employee_Id : ");
                Employee_Id = int.Parse(Console.ReadLine());
                Console.Write("Enter Employee Name : ");
                Name = Console.ReadLine();
                Console.Write("Enter Employee D.O.B : ");
                DOB = Console.ReadLine();
                Console.Write("Enter Employee Email : ");
                Email = Console.ReadLine();
                Console.Write("Enter Employee Address : ");
                Address = Console.ReadLine();
                Console.Write("Enter Employee Job-Title : ");
                Job_Title = Console.ReadLine();
                Console.Write("Enter Employee Salary : ");
                Salary = int.Parse(Console.ReadLine());
                Console.WriteLine("\nWriting To a File....");
                var path = @"D:\UserData.txt";
                StreamWriter writer = new StreamWriter(path);
                writer.WriteLine($"Employee Id = {Employee_Id}\nName : {Name}\nD.O.B = {DOB}\n" +
                    $"Email = {Email}\nAddress = {Address}\nJobTitle = {Job_Title}\nSalary = {Salary}");
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Reader(string path)
        {
            try
            {
                Console.WriteLine("\nReading From a File...\n");
                StreamReader Reader = new StreamReader(path);
                string Data = Reader.ReadToEnd();
                Console.WriteLine(Data);
                Reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Menu()
        {
            Console.WriteLine("-------General Store---------\n");
            Console.WriteLine("Press \"1\" To Add Data");
            Console.WriteLine("Press \"2\" To View Data");
            var path = @"D:\GroceryItem.txt";
            int Ans = int.Parse(Console.ReadLine());
            if (Ans == 1)
            {
                Add_Item();
                Console.WriteLine("Data Is Written To The File...!!!");
            }
            else if (Ans == 2)
            {
                Reader(path);
            }
            else
            {
                Console.WriteLine("Invalid Input...");
            }
        }

        private static void Add_Item()
        {
            try
            {
                string Item_Id, Name, Mfg_Date, Exp_Date; int Quantity, Price;
                var path = @"D:\GroceryItem.txt";
                Console.Write("Enter Item Id : ");
                Item_Id = Console.ReadLine();
                Console.Write("Enter Item Name : ");
                Name = Console.ReadLine();
                Console.Write("Enter Mfg Date : ");
                Mfg_Date = Console.ReadLine();
                Console.Write("Enter Exp Date : ");
                Exp_Date = Console.ReadLine();
                Console.Write("Enter Quantity : ");
                Quantity = int.Parse(Console.ReadLine());
                Console.Write("Enter Item Price : ");
                Price = int.Parse(Console.ReadLine());
                FileStream Stream = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(Stream);
                writer.WriteLine($"{Item_Id}, {Name}, {Mfg_Date}, {Exp_Date}, {Quantity}, {Price}");
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ReadNumber(int [] array, int start, int end)
        {
            Console.WriteLine("\nReading From The Array...\n");
            for (int i = start; i <= end; i++)
            {
                Console.Write("Element [{0}] : ", i);
                Console.WriteLine(array[i]);
            }
        }

        private static void Writing()
        {
            string ans = null;
            do
            {
                Console.Write("Enter the file name: ");
                string Filename = Console.ReadLine();
                if (!File.Exists(Filename))
                {
                    Console.WriteLine("{0} does not exist!", Filename);
                    return;
                }
                StreamWriter sr = File.AppendText(Filename);
                Console.Write("Enter a string to be written to the file: ");
                String str = Console.ReadLine();
                sr.WriteLine(str);
                sr.Close();
                Console.Write("Do you want to continue [Y/N]: ");
                ans = Console.ReadLine();
            } while (ans == "y" || ans == "Y");
        }
    }
}