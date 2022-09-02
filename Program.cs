using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionstore
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choices\nPress 1 for Category\nPress 2 for Product");
            int input =int.Parse(Console.ReadLine());
            if (input==1)
            {
                Console.WriteLine("Enter 1 to insert\nEnter 2 to delete\nEnter 3 to update\nEnter 4 to display");
                int choices = int.Parse(Console.ReadLine());
                category c = new category();
                switch (choices)
                {
                    case 1:

                        if (c.Add()==1)
                        {
                            Console.WriteLine("Inserted successfully");
                            Console.Read();
                        }
                        break;

                    case 2:
                        if (c.Delete() == 1)
                        {
                            Console.WriteLine("Deleted successfully");
                            Console.Read();
                        }
                        break;

                    case 3:
                        if (c.Update() == 1)
                        {
                            Console.WriteLine("Updated successfully");
                            Console.Read();
                        }
                        break;

                    case 4:
                        c.Display();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            else if (input==2)
            {
                Console.WriteLine("Enter 1 to insert\nEnter 2 to delete\nEnter 3 to update\nEnter 4 to display");
                int choices = int.Parse(Console.ReadLine());
                product p= new product();
                switch (choices)
                {
                    case 1:

                        if (p.Add() == 1)
                        {
                            Console.WriteLine("Inserted successfully");
                            Console.Read();
                        }
                        break;

                    case 2:
                        if (p.Delete() == 1)
                        {
                            Console.WriteLine("Deleted successfully");
                            Console.Read();
                        }
                        break;

                    case 3:
                        if (p.Update() == 1)
                        {
                            Console.WriteLine("Updated successfully");
                            Console.Read();
                        }
                        break;

                    case 4:
                        p.Display();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            
                


        }
    }
}
