using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.BIT.Models
{
    internal class Triangle
    {
        public decimal SideOne;
        public decimal SideTwo;
        public decimal SideThree;
        public static double AreaFromThreeSides(double a, double b, double c) {
            var s = (a + b + c) / 2;
            var exp = s * (s - a) * (s - b) * (s - c);
            if (exp < 0)
            {
                Console.WriteLine("The values entered cannot make up a triangle");
                return 0;
            }
            var area = Math.Sqrt(exp);
            return area;
        }

        public static double AreaFromBaseHeight(double _base, double height)
        {
            return (_base * height) / 2;
        }
        
        //public string CalculateArea()
        //{
        //    Console.WriteLine("Enter length of side one: ");
        //    var sideOne = Console.ReadLine();
        //    if (!double.TryParse(sideOne, out double a))
        //    {
        //        return "Invalid value entered. Enter number only";
        //    }
        //    Console.WriteLine("Enter length of side two: ");
        //    var sideTwo = Console.ReadLine();
        //    if (!double.TryParse(sideTwo, out double b))
        //    {
        //        return "Invalid value entered. Enter number only";
        //    }
        //    Console.WriteLine("Enter length of side three: ");
        //    var sideThree = Console.ReadLine();    
        //    if (!double.TryParse(sideThree, out double c))
        //    {
        //        return "Invalid value entered. Enter number only";
        //    }
        //    var area = AreaFromThreeSides(a, b, c);
        //    return $"Triangle area is: {area}";
        //}
    }
}
