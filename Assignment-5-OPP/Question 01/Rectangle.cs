using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_OPP.Question_01
{
    public class My_Rectangle : IRectangle
    {
        public double Width { get; }
        public double Height { get; }

        public My_Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area => Width * Height;

        double IRectangle.Width { get => Width; set => throw new NotImplementedException(); }
        double IRectangle.Height { get => Height; set => throw new NotImplementedException(); }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area}");
        }
    }
}
