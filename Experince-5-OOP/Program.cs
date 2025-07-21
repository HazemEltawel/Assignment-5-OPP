using Assignment_5_OPP.Question_02;
using Assignment_5_OPP.Question_01;
using System;
using System.Diagnostics.Metrics;
using System.Drawing;
class Program
{
    private static string password;

    static void Main(string[] args)
    {
        #region Question 01
        //Assignment_5_OPP.Question_01.MyCircle circle = new MyCircle(5);

        //Assignment_5_OPP.Question_01.IRectangle rectangle = new My_Rectangle(4, 6);
        //circle.DisplayShapeInfo();
        //rectangle.DisplayShapeInfo();
        #endregion

        #region Question 02

        IAuthenticationService authService = new BasicAuthenticationService();

        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (authService.Authenticate(username, password))
        {
            Console.Write("Enter role to check: ");
            string role = Console.ReadLine();

            if (authService.Authenticate(username, role))
            {
                Console.WriteLine("User is authenticated and authorized.");
            }
            else
            {
                Console.WriteLine("User is authenticated but not authorized.");
            }
        }
        else
        {
            Console.WriteLine("Authentication failed.");
        }

        #endregion







    }
    }
