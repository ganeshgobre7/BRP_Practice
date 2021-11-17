using System;

namespace StarPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Star Pyramid");
            Pyramid pyramid = new Pyramid();
            /*//pyramid.HalfPyramid();
            // pyramid.InvertedHalfPyramid();
            //pyramid.HollowInvertedHalfPyramid();
            pyramid.Pattern();
            pyramid.Pattern1();
            pyramid.Pattern2();*/
            pyramid.Pattern3();
        }
    }
}
