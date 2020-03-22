using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Enter the length & width of the rectangle");
            Boolean check;
            do
            {
                try
                {
                    check = true;
                    Console.WriteLine("Length: ");
                    length = int.Parse(Console.ReadLine());
                    if (length <= 0)
                    {
                        Console.WriteLine("Enter the length greater than zero");
                        check = true;
                    }
                    else
                    {
                        rectangle.SetLength(length);
                        check = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter the valid number");
                    check = true;
                }

            } while (check == true);

            do
            {
                try
                {
                    check = true;
                    Console.WriteLine("Width: ");
                    width = int.Parse(Console.ReadLine());
                    if (width <= 0)
                    {
                        Console.WriteLine("Enter the width greater than zero");
                        check = true;
                    }
                    else
                    {
                        rectangle.SetWidth(width);
                        check = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter the valid number");
                }
            } while (check == true);


            do
            {
                try
                {
                    Console.WriteLine("Menu:\n" + "1. Get Rectangle Length\n" + "2. Change Rectangle Length\n" + "3. Get Rectangle Width\n" + "4. Change Rectangle Width\n" + "5. Get Rectangle Perimeter\n" + "6. Get Rectangle Area\n" + "7. Exit");
                    int option = int.Parse(Console.ReadLine());

                    check = false;
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine(rectangle.GetLength());
                            check = true;
                            break;
                        case 2:
                            Console.WriteLine("Enter the new length");
                            int nLength = int.Parse(Console.ReadLine());
                            newLength(nLength);
                            check = true;
                            break;
                        case 3:
                            Console.WriteLine(rectangle.GetWidth());
                            check = true;
                            break;
                        case 4:
                            Console.WriteLine("Enter the new width");
                            int nWidth = int.Parse(Console.ReadLine());
                            newWidth(nWidth);
                            check = true;
                            break;
                        case 5:
                            Console.WriteLine(rectangle.GetPerimeter());
                            check = true;
                            break;
                        case 6:
                            Console.WriteLine(rectangle.GetArea());
                            check = true;
                            break;
                        case 7:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Choose the correct option");
                            check = true;
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter the valid input");
                    check = true;
                }
            } while (check == true);

            void newLength(int recLength)
            {
                do
                {
                    try
                    {
                        check = true;
                        if (recLength <= 0)
                        {
                            Console.WriteLine("Enter the length greater than zero");
                            check = false;
                        }
                        else
                        {
                            rectangle.SetLength(recLength);
                            Console.WriteLine("Length changed successfully");
                            check = false;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter the valid number");
                    }
                } while (check == true);
            }
            void newWidth(int recWidth)
            {
                do
                {
                    try
                    {
                        check = true;
                        if (recWidth <= 0)
                        {
                            Console.WriteLine("Enter the width greater than zero");
                            check = false;
                        }
                        else
                        {
                            rectangle.SetWidth(recWidth);
                            Console.WriteLine("Width changed successfully");
                            check = false;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter the valid number");
                    }
                } while (check == true);

            }
        }
    }
}
