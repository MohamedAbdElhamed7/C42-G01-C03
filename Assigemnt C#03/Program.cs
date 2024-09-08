

namespace Assigemnt_C_03
{
    class Point
    {
        public int x;
        public int y;
    }
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

            #region Question 18
            //Q18.Within a company, the efficiency of workers is evaluated based
            //on the duration required to complete a specific task.
            //A worker's efficiency level is determined as follows:

            //- If the worker completes the job within 2 to 3 hours,
            //they are considered highly efficient.

            //If the worker takes 3 to 4 hours, they are instructed to increase their speed.

            // If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 

            //If the worker takes more than 5 hours, they are required to leave the company.

            //Console.WriteLine("Enter the time taken for the task");
            //int time = int.Parse(Console.ReadLine());


            //if (time <= 3)
            //    Console.WriteLine("highly efficient");
            //else if (time <= 4)
            //    Console.WriteLine("You need to increase your speed");
            //else if (time <= 5)
            //    Console.WriteLine("You need a training to enhance your speed");
            //else
            //    Console.WriteLine("You have to leave the company");

            #endregion

            #region Question 21
            //Q21.Write C# program that Assigning one value type variable to another and
            //modifying the value of one variable and mention what will happen



            //int x = 5;
            //int y = 8;

            //x = y;
            //so x will be equals to 8

            //y = 3;
            // so y will be equal 3 but x will still equals to 8
            // becouse x = y thats mean that x equals to the  value of y (8) not equal to the y
            // so x will not change from 8 to 3 

            //Console.WriteLine($"The value of x is : {x}");
            //Console.WriteLine($"The value of y is : {y}");


            #endregion

            #region Question 22
            //Q3.Write C# program that Assigning one reference type variable to another
            //and modifying the object through one variable and mention what will happen


            //Point P1;
            // Declare for reference from point , refer null 
            //Allocate 4 bytes at stack
            //P1 = new Point();
            // allocate require bytes at heap , 8bytes 
            //P1.x = 1;
            //P1.y = 2;

            //Point P2 = new Point(); // unreachable object 
            //P2 = P1;

            //if there is change at value of p2 p1 will have same change also if p1 have changes
            //p2 will have  the same because p1 and p2 refere for same location at heap  
            #endregion

            #region Question 23

            // d) 
            // becouse d = not the false so it will be true and it's an integer so it will be equals 1


            #endregion

            #region  Question 24
            //What will be the output of the C# code given below?
            // Console.WriteLine(13 / 2 + " " + 13 % 2);

            //the answer : d) 6 1

            // becouse 13/2 it equals 6.5 but becouse both of them are integers so the answer will be integer
            // so it will be only 6 and 13 modulas 2 it will be only 1 and there spaces between both equation 
            // so the final answer is 6 1
            #endregion

            #region Question 25
            //What will be the output of the C# code given below?
            // int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            // the answer : d) 7 7 

            // becouse the condition is not the flase(1 <= 0) so  it will be true 
            // so the compiler will print this equation (++num + z++ + " " + ++z) and this equation 
            // equals : num became equals 2 and z will be same value 5 and increase 1 after summition
            // and became 6 so frist part(++num + z++) equals 7 and sec part z will increament 1 so it
            // will be 7  so the final answer is 7 7
            #endregion
        }
    }
}
