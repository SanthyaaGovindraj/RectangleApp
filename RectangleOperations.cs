using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleApp
{
    public class RectangleOperations

    {
        public static int MenuChoice()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)

            {

                Console.WriteLine("1.Get Rectangle Length");
                Console.WriteLine("2.Change Rectangle Length");
                Console.WriteLine("3.Get Rectangle Width");
                Console.WriteLine("4.Change Rectangle Width");
                Console.WriteLine("5.Get Rectangle Perimeter");
                Console.WriteLine("6.Get Rectangle Area");
                Console.WriteLine("7.Exit\n");

                Console.WriteLine("Please select an option:\n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7")
                {
                    Console.WriteLine("That's not a valid menu option, please try again:\n");
                }
                else
                {
                    validMenuSelect = true;
                }
            }

            Console.WriteLine();
            return int.Parse(userInput);
        }


        static void Main()
        {
            Rectangle r = new Rectangle();
            int selection;
            Console.WriteLine("Please enter the length and width of the rectangle:");
            string measure = Console.ReadLine();
            int[] nums = Array.ConvertAll(measure.Split(','), int.Parse);
            int a = nums[0];
            int b = nums[1];
            if (a < 1 && b < 1)
            {
                Console.WriteLine("That's not a valid selection, please try again.\n");
            }
            else
            {
                selection = MenuChoice();

                while (selection != 7)
                {
                    int result;

                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine($"Length is: {r.GetLength(a)}\n");
                            break;
                        case 2:
                            Console.WriteLine("Enter a value to change the length:\n");
                            result = a;
                            a = int.Parse(Console.ReadLine());
                            r.SetLength(a);
                            Console.WriteLine($"Length is chnaged to {a}\n");
                            break;
                        case 3:
                            Console.WriteLine($"width is: {r.GetWidth(b)}\n");
                            break;
                        case 4:
                            Console.WriteLine("Enter a value to change the width:\n");
                            result = b;
                            b = int.Parse(Console.ReadLine());
                            r.SetWidth(b);
                            Console.WriteLine($"Length is chnaged to {b}\n");
                            break;
                        case 5:
                            Console.WriteLine($"The perimeter of rectangle is: {r.GetPerimeter(a,b)}\n");
                            break;
                        case 6:
                            Console.WriteLine($"The area of rectangle is: {r.GetArea(a,b)}\n");
                            break;
                        default:
                            break;
                    }

                    selection = MenuChoice();

                }

                }

            }
        }
    }



        