using System;
using System.Collections.Generic;
using System.Text;

namespace StarPyramid
{
    class Pyramid
    {
        public void HalfPyramid()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void InvertedHalfPyramid()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void HollowInvertedHalfPyramid()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j == 1 || i + j == 6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();               
            }
        }
        public void Pattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (j<=6-i || j>=4+i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void Pattern1()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (j>=5-i && j<=3+i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void Pattern2()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (j >= i && j <= 8 - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void Pattern3()//HomeWork
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
