using Assignment_5_OPP.Question_01;
using System.Drawing;
using System;
class Program
{
    static void Main(string[] args)
    {
        Assignment_5_OPP.Question_01.MyCircle circle = new MyCircle(5);

        Assignment_5_OPP.Question_01.IRectangle rectangle = new My_Rectangle(4, 6);
        circle.DisplayShapeInfo();
        rectangle.DisplayShapeInfo(); 
     }
}