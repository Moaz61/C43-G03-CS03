using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Write a program that allows the user to enter a number then print it.

            //double num;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("Enter a number: ");
            //    flag = double.TryParse(Console.ReadLine(), out num);
            //}
            //while (!flag);
            //Console.WriteLine("You entered: " + num);
            #endregion

            #region 2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            //String txt ;
            //Console.WriteLine("enter a string to connvert to int: ");
            //txt = Console.ReadLine();
            //int result = Convert.ToInt32(txt);
            //An unhandled exception of type 'System.FormatException' occurred in System.Private.CoreLib.dll
            //The input string 'moaz61' was not in a correct format.
            //can not convert txt to integer as it contains letters so runtime error occurs
            #endregion

            #region  3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //double num1 = 1.1, num2 = 2.1, sum = 0;
            //sum = num1 + num2;
            //Console.WriteLine("Sum is: " + sum);
            #endregion

            #region 4.Write C# program that Extract a substring from a given string.

            //string txt = "Hello World";
            //string substring = txt.Substring(0,5);
            //Console.WriteLine("Substring is: " +substring);
            #endregion

            #region 5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int x = 1 , y = 2 ;

            //x = y; // x = 2 , y = 2

            //x = 3;

            //Console.WriteLine($"X = {x} , Y = {y}");  // x = 3 , y = 2
            #endregion

            #region 6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //int[] arr1 = { 1, 2, 3 };

            //int[] arr2 = arr1; // both arrays now will be pointing to same values

            //arr2[0] = 5; // first element

            //Console.WriteLine($"Arr1 = {arr1[0]} , Arr2 = {arr2[0]}");
            #endregion

            #region 7.Write C# program that take two string variables and print them as one variable 
            //Console.WriteLine("Enter first string: ");
            //string txt1 = Console.ReadLine(); 

            //Console.WriteLine("Enter second string: ");
            //string txt2 = Console.ReadLine(); 

            //string txt3 = txt1 + txt2;

            //Console.WriteLine($"whole string is: {txt3} ");
            #endregion

            #region 8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is 

                        //double principal, rate, time;

                        //do
                        //{
                        //    Console.Write("enter the principal amount: ");
                        //} while (!double.TryParse(Console.ReadLine(), out principal) || principal <= 0);

                        //do
                        //{
                        //    Console.Write("enter the rate of interest: ");
                        //} while (!double.TryParse(Console.ReadLine(), out rate) || rate <= 0);

                        //do
                        //{
                        //    Console.Write("enter the time: ");
                        //} while (!double.TryParse(Console.ReadLine(), out time) || time <= 0);

                        //double interest = (principal * rate * time) / 100;

                        //Console.WriteLine($"The interest is: {interest}");

            #endregion

            #region 9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is

            //double weight;
            //double height;

            //do
            //{
            //    Console.Write("enter your weight in kilograms: ");
            //} while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0);

            //do
            //{
            //    Console.Write("enter your height in centimeters: ");
            //} while (!double.TryParse(Console.ReadLine(), out height) || height <= 0);

            //double BMI = weight / (height * height);

            //Console.WriteLine($"Your BMI is: {BMI}");

            #endregion

            #region 10.Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            //double temp;

            //do{
            //    Console.WriteLine("enter the temp: ");
            //}
            //while (!double.TryParse(Console.ReadLine(),out temp) || temp <= 0);

            //string result = temp < 10 ? "too cold" : temp > 30 ? "too hot" : "just good";
            //Console.WriteLine(result);

            #endregion

            #region 11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //DateTime date = DateTime.Now;

            //string format1 = $"{date.Day} , {date.Month} , {date.Year}";
            //string format2 = $"{date.Day} / {date.Month} / {date.Year}";
            //string format3 = $"{date.Day} - {date.Month} - {date.Year}";

            //Console.WriteLine(format1);
            //Console.WriteLine(format2);
            //Console.WriteLine(format3);

            ////////////////////////////////////////////////////////////////

            //bool dayFlag;
            //int day;
            //do
            //{
            //    Console.WriteLine("Enter day: ");
            //    dayFlag = int.TryParse(Console.ReadLine(), out day);
            //} while (!dayFlag || (day > 31 || day < 1));

            //bool monthFlag;
            //int month;
            //do
            //{
            //    Console.WriteLine("Enter month: ");
            //    monthFlag = int.TryParse(Console.ReadLine(), out month);
            //} while (!monthFlag || (month > 12 || month < 1));

            //bool yearFlag;
            //int year;
            //do
            //{
            //    Console.WriteLine("Enter year: ");
            //    yearFlag = int.TryParse(Console.ReadLine(), out year);
            //} while (!yearFlag || (year < 1));

            //string format1 = $"date is: {day}, {month}, {year}";
            //string format2 = $"date is: {day} / {month} / {year}";
            //string format3 = $"date is: {day}-{month}-{year}";

            //Console.WriteLine(format1);
            //Console.WriteLine(format2);
            //Console.WriteLine(format3);

            #endregion

            #region 12- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //int num;
            //bool validinput;

            //do 
            //{
            //    Console.WriteLine("enter the number to divide: ");
            //    validinput = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (!validinput);

            //if (num % 3 == 0 && num % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            #endregion

            #region 13- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //int num;
            //bool validInput;

            //do
            //{
            //    Console.Write("enter an number: ");
            //    validInput = int.TryParse(Console.ReadLine(), out num);

            //} while (!validInput); 

            //if (num < 0)
            //    Console.WriteLine("negative");
            //else

            //    Console.WriteLine("positive");

            #endregion

            #region 14- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //int num1, num2, num3;

            //int GetValidNum(string operation)
            //{
            //    int result;
            //    bool validInput;
            //    do
            //    {
            //        Console.Write(operation);
            //        validInput = int.TryParse(Console.ReadLine(), out result);
            //    } 
            //    while (!validInput);

            //    return result;
            //}

            //Console.WriteLine("enter three integers");
            //num1 = GetValidNum("first number: ");
            //num2 = GetValidNum("second number: ");
            //num3 = GetValidNum("third number: ");

            //if (num1 > num2 && num1 > num3)
            //{
            //    if (num2 > num3)
            //        Console.WriteLine($"Max = {num1} and Min ={num3}");
            //    else
            //        Console.WriteLine($"Max = {num1} and Min ={num2}");

            //}
            //else if (num2 > num1 && num2 > num3)
            //{
            //    if (num1 > num3)
            //        Console.WriteLine($"Max = {num2} and Min ={num3}");
            //    else
            //        Console.WriteLine($"Max = {num2} and Min ={num1}");

            //}
            //else if (num3 > num1 && num3 > num2)
            //{
            //    if (num1 > num2)
            //        Console.WriteLine($"Max = {num3} and Min ={num2}");
            //    else
            //        Console.WriteLine($"Max = {num3} and Min ={num1}");
            //}
            //else
            //    Console.WriteLine("Numbers are Equale");

            #endregion

            #region 14- Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //int number;
            //bool flage;

            //do
            //{

            //    Console.WriteLine("enter number: ");
            //    flage = int.TryParse(Console.ReadLine(), out number);

            //} while (!flage);

            //if (number % 2 == 0)
            //    Console.WriteLine("even");
            //else
            //    Console.WriteLine("odd");
            #endregion

            #region 15- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //char C;
            //bool flage;

            //do
            //{
            //    Console.WriteLine("enter character: ");
            //    flage = char.TryParse(Console.ReadLine().ToLower(), out C);

            //} while (!flage);

            //if (C == 'a' || C == 'e' || C == 'i' || C == 'o' || C == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //    Console.WriteLine("consonant");
            #endregion

            #region 16- Write a program to input the month number and print the number of days in that month.
            //int month;
            //bool flage;

            //do
            //{
            //    Console.Write("enter the month: ");
            //    flage = int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12;

            //} while (!flage);

            //int days = 0;

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        days = 31;
            //        break;
            //    case 2:
            //        days = 28;
            //        break;
            //    default:
            //        days = 30;
            //        break;
            //}

            //Console.WriteLine($"Days in Month {month} are : {days}");
            #endregion

            #region 17- Write a program to create a Simple Calculator.
            //Console.WriteLine("Choose an operation:");
            //Console.WriteLine("1. Add (+)");
            //Console.WriteLine("2. Subtract (-)");
            //Console.WriteLine("3. Multiply (*)");
            //Console.WriteLine("4. Division (/)");

            //int choice;
            //bool flage;

            //do
            //{
            //    Console.Write("Enter your choice (1-4): ");
            //    flage = int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4;

            //} while (!flage);

            //double num1;
            //bool validNum1;
            //do
            //{
            //    Console.Write("Enter the first number: ");
            //    validNum1 = double.TryParse(Console.ReadLine(), out num1);

            //} while (!validNum1);

            //double num2;
            //bool validNum2;
            //do
            //{
            //    Console.Write("Enter the second number: ");
            //    validNum2 = double.TryParse(Console.ReadLine(), out num2);

            //} while (!validNum2);

            //double result = 0;
            //bool validOperation = true;

            //switch (choice)
            //{
            //    case 1:
            //        result = num1 + num2;
            //        Console.WriteLine($"Result: {num1} + {num2} = {result}");
            //        break;
            //    case 2:
            //        result = num1 - num2;
            //        Console.WriteLine($"Result: {num1} - {num2} = {result}");
            //        break;
            //    case 3:
            //        result = num1 * num2;
            //        Console.WriteLine($"Result: {num1} * {num2} = {result}");
            //        break;
            //    case 4:
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //            Console.WriteLine($"Result: {num1} / {num2} = {result}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Division by zero is not allowed.");
            //            validOperation = false;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid");
            //        break;
            //}

            #endregion

            #region 18.Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //int number;
            //bool flage;

            //do
            //{
            //    Console.WriteLine("enter number: ");
            //    flage = int.TryParse(Console.ReadLine(), out number);
            //} 
            //while (!flage);

            //for (int i = 1; i <= number; i++)
            //    Console.WriteLine(i);
            #endregion

            #region 19 - Write a program that allows the user to insert an integer then

            //int Number;
            //bool flage;

            //do
            //{
            //    Console.WriteLine("Enter Number: ");
            //    flage = int.TryParse(Console.ReadLine(), out Number);
            //} while (!flage);

            //for (int i = 0; i <= 12; i++)
            //    Console.WriteLine($"{Number} * {i} = {Number * i}");
            #endregion

            #region 20- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //int Number;
            //bool flage;

            //do
            //{
            //    Console.WriteLine("Enter Number: ");
            //    flage = int.TryParse(Console.ReadLine(), out Number);
            //} while (!flage);


            //for (int i = 0; i <= Number; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region 21- Write a program that takes two integers then prints the power.
            //double Result = 1;
            //int Base;
            //bool flage1;
            //do
            //{
            //    Console.WriteLine("Enter Number Base");
            //    flage1 = int.TryParse(Console.ReadLine(), out Base);

            //} while (!flage1);

            //int Power;
            //bool flage2;

            //do
            //{
            //    Console.WriteLine("Enter Number Power");
            //    flage2 = int.TryParse(Console.ReadLine(), out Power);

            //} while (!flage2);


            //for (int i = 0; i < Power; i++)
            //{
            //    Result *= Base;
            //}
            //Console.WriteLine($"{Base} ^ {Power} = {Result}");

            #endregion

            #region 22- Write a program to allow the user to enter int and print the REVERSED of it.
            //int Num;
            //bool flage;

            //do
            //{
            //    Console.WriteLine("Enter a number: ");
            //    flage = int.TryParse(Console.ReadLine(), out Num);
            //} while (!flage);

            //string s = Convert.ToString(Num);

            //if (Num >= 0)
            //{
            //    for (int i = s.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(s[i]);
            //    }
            //}
            //else
            //{
            //    Console.Write('-');
            //    for (int i = s.Length - 1; i > 0; i--)
            //    {
            //        Console.Write(s[i]);
            //    }
            //}
            #endregion

            #region 23- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //int Start;
            //bool flage;

            //do
            //{
            //    Console.WriteLine("enter first number: ");
            //    flage = int.TryParse(Console.ReadLine(), out Start);

            //} while (!flage);

            //int End;
            //bool flage2;

            //do
            //{
            //    Console.WriteLine("enter second number");
            //    flage2 = int.TryParse(Console.ReadLine(), out End);

            //} while (!flage2);

            //for (int i = Start; i <= End; i++)
            //{
            //    int count = 0;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //    if (count == 0 & i != 1)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region 24- Write a program in C# Sharp to convert a decimal number into binary without using an array
            //int Num;
            //bool Flag;

            //string binary = "";

            //do
            //{
            //    Console.WriteLine("enter number");
            //    Flag = int.TryParse(Console.ReadLine(), out Num);

            //} while (!Flag || !(Num >= 0));

            //if (Num == 0)
            //    Console.WriteLine(0);
            //else
            //{
            //    while (Num > 0)
            //    {
            //        binary = (Num % 2) + binary;
            //        Num /= 2;
            //    }

            //    Console.WriteLine(binary);
            //}
            #endregion

            #region 25- Write a program in C# Sharp to find the sum of all elements of the array
            //int Size;
            //bool flag;

            //do
            //{
            //    Console.Write("Enter the size of array: ");
            //    flag = int.TryParse(Console.ReadLine(), out Size) && Size > 0;

            //} while (!flag);

            //int[] number = new int[Size];
            //int sum = 0;

            //for (int i = 0; i < Size; i++)
            //{
            //    bool flag2;
            //    do
            //    {
            //        Console.Write($"Enter element {i + 1}: ");
            //        flag2 = int.TryParse(Console.ReadLine(), out number[i]);

            //    } while (!flag2);

            //    sum += number[i]; 
            //}

            //Console.WriteLine($"The sum of elements in array is: {sum}");
            #endregion
        }
    }
}
