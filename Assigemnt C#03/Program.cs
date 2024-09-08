using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigemnt_C_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //1- Write a program that takes a number from the user then print
            //yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Eneter The Number ");
            //int Number = int.Parse(Console.ReadLine());

            //if (Number % 3 == 0 && Number % 4 == 0)
            //    Console.WriteLine("yes");
            //else 
            //    Console.WriteLine("no");


            #endregion

            #region Question 2
            //Q2.Write a program that allows the user to insert an integer
            //then print negative if it is negative number otherwise print positive.

            //Console.WriteLine("Please Eneter an Integre Number ");
            //int Number = int.Parse(Console.ReadLine());

            //if (Number < 0)
            //    Console.WriteLine("negative");
            //else
            //    Console.WriteLine("positive");


            #endregion

            #region Question 3
            //Q3- Write a program that takes 3 integers from the user
            //then prints the max element and the min element.

            //Console.WriteLine("Please Eneter 3 Integer Numbers ");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());

            //int max = 0, min = 0;

            //if (num1 >= num2 && num1 >= num3)
            //{
            //    max = num1;
            //    if(num2 >= num3 )
            //        min = num3;
            //    else
            //        min = num2;
            //}
            //else if (num2 >= num1 && num2 >= num3)
            //{
            //    max = num2;
            //    if (num1 >= num3)
            //        min = num3;
            //    else
            //        min = num1;
            //}
            //else
            //{
            //    max = num3;
            //    if (num1 >= num2)
            //        min = num2;
            //    else
            //        min = num1;
            //}

            //Console.WriteLine($"Max : {max}, Min : {min}");


            #endregion

            #region Question 4
            //Q4.Write a program that allows the user to insert 
            //an integer number then check If a number is even or odd.


            //Console.WriteLine("Please enter an Integer Number");
            //int Number = int.Parse(Console.ReadLine());

            //if (Number % 2 == 0)
            //    Console.WriteLine("it is even number");
            //else
            //    Console.WriteLine("It is an odd Number");

            #endregion

            #region Question 5
            //Q5.Write a program that takes character from the user then if it is
            //a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).

            //Console.WriteLine("Please Enter a character ");
            //char ch = Convert.ToChar(Console.ReadLine());

            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //    Console.WriteLine("vowel");
            //else
            //    Console.WriteLine("consonant");

            #endregion

            #region Question 7
            //Q7 - Write a program that allows the user to insert an integer then
            //print a multiplication table up to 12.

            //Console.WriteLine("Please Enter An Iteger Number");
            //int Number = int.Parse(Console.ReadLine());

            //for(int i=1; i<=12; i++)
            //{
            //    Console.Write($"{Number*i} " );
            //}


            #endregion

            #region Question 9
            //Q9.Write a program that takes two integers then prints the power

            //Console.WriteLine("Enter Two Integers Numbers (the number and the power)");
            //int num = int.Parse(Console.ReadLine());
            //int pow = int.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Pow(num, pow));
            #endregion

            #region Question 10
            //Q10.10- Write a program to enter marks of five subjects and
            //calculate total, average and percentage.

            //Console.WriteLine("please Enter Your Grades");
            //int grade1 = int.Parse(Console.ReadLine());
            //int grade2 = int.Parse(Console.ReadLine());
            //int grade3 = int.Parse(Console.ReadLine());
            //int grade4 = int.Parse(Console.ReadLine());
            //int grade5 = int.Parse(Console.ReadLine());

            //int total = grade1 + grade2 + grade3 + grade4 + grade5;
            //int average = total / 5;

            //Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"Average Marks = {average}");
            //Console.WriteLine($"Percentage = {average}");
            #endregion

            #region Question 11
            //Q11.Write a program to input the month number and
            //print the number of days in that month.

            //Console.WriteLine("Please Enter The month Number");
            //int MonthNum = int.Parse(Console.ReadLine());

            //switch (MonthNum)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("31");
            //        break;
            //    case 2:
            //        Console.WriteLine("28");
            //        break;
            //    case > 12:
            //        Console.WriteLine("Invalid Month Number");
            //        break;
            //    default:
            //        Console.WriteLine("30");
            //        break;
            //}


            #endregion

            #region Question 17
            //17- Create a program that asks the user to input three points (x1, y1),
            //(x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.WriteLine("Please Enter The Frist Point");
            //int x1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter The Frist Point");
            //int y1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter The Secound  Point");
            //int x2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter The Secound Point");
            //int y2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter The Third Point");
            //int x3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter The Third Point");
            //int y3 = int.Parse(Console.ReadLine());

            //if (y2 - y1 / x2 - x1 == y3 - y2 / x3 - x2)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");



            #endregion

        }
    }
}
