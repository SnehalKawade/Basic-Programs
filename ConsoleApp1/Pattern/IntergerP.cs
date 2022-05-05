using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Pattern
{
    class IntergerP
    {
        //pattern 1
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class IntergerP1
    {
        //pattern 4
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

    class IntergerP2
    {
        //pattern 14
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class IntergerP3
    {
        //pattern 15
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }


    class IntergerP4
    {
        //Pattern 16
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine(); 
            }
        }
    }


    class IntergerP5
    {
        //pattern 17
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }


    class IntergerP6
    {
        //patter 7
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int space = 5; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }



    class IntergerP7
    {
        //pattern 12
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int space = 5; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }



    class IntergerP8
    {
        //pattern 8
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {

                for (int space = 1; space < i; space++)
                {
                    Console.Write(" ");
                }


                for (int j = i; j <= 5; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }



    class IntergerP9
    {
        //pattern 24
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }



    class IntergerP10
    {
        //pattern 28
        static void Main(string[] args)
        {
            for (int i = 5; i > 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }


    class IntergerP11
    {
        //pattern 38
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int space = 5; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (int i = 4; i >= 1; i--)
            {
                for (int space = 5; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
    }


    class IntergerP12
    {
        //pattern 33
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int space = 5; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int k = i - 1; k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }


    class IntergerP13
    {
        //pattern 29
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= 5; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class IntergerP14
    {
        //pattern 22
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int space = 5; space > i; space--)
                {
                    Console.Write(" ");
                }
                int temp = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(temp + " ");
                    temp = temp * (i - j) / j;
                }
                Console.WriteLine();
            }
        }
    }


    class IntergerP15
    {
        //pattern 35
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("0 ");
                }
                Console.Write(i + " ");
                for (int k = i; k < 5; k++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }

    class IntergerP16
    {
        //pattern 36
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("1 ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }




}
