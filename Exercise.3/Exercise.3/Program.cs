using System;

namespace Exercise._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width of image:");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter height of image:");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.landskape : ImageOrientation.portrait;
            Console.WriteLine("Image Orientation is "+ orientation);
        }
    }
}
