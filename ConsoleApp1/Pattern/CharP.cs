using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Pattern
{
    class CharP
    {
        //pattern 5
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }



    class CharP1
    {
        //pattern 2
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class CharP2
    {
        //pattern 18
        static void Main(string[] args)
        {
            for (char i = 'E'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class CharP3
    {
        //pattern 13
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char space = 'E'; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class CharP4
    {
        //pattern 9
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char space = 'E'; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }


    class CharP5
    {
        //pattern 10
        static void Main(string[] args)
        {
            for (char i = 'E'; i >= 'A'; i--)
            {

                for (char space = 'A'; space < i; space++)
                {
                    Console.Write(" ");
                }

                for (char j = i; j <= 'E'; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }


    class CharP6
    {
        //pattern 19
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'E'; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }


    class CharP7
    {
        //pattern 20
        static void Main(string[] args)
        {
            for (char i = 'E'; i >= 'A'; i--)
            {
                for (char j = 'E'; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }


    class CharP8
    {
        //pattern 21
        static void Main(string[] args)
        {
            char k = 'A';
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }


    class CharP9
    {
        //pattern 25
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }


    class CharP10
    {
        //pattern 30
        static void Main(string[] args)
        {
            for (char i = 'E'; i > 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }



    class CharP11
    {
        //pattern 39
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char space = 'E'; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char space = 'E'; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
    }



    class CharP12
    {
        //pattern 31
        static void Main(string[] args)
        {
            for (char i = 'E'; i >= 'A'; i--)
            {
                for (char j = i; j >= 'A'; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (char i = 'B'; i <= 'E'; i++)
            {
                for (char j = i; j >= 'A'; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }


    class CharP13
    {
        //pattern 34
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char space = 'E'; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }

                for (char k = (char)(i - 1); k >= 'A'; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }


    class CharP14
    {
        //pattern 23
        static void Main(string[] args)
        {
            int alpha = 65;
            for (int i = 1; i <= 5; i++)
            {
                for (int space = 5; space > i; space--)
                {
                    Console.Write(" ");
                }
                int temp = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(alpha - 1 + temp) + " ");
                    temp = temp * (i - j) / (j);
                }
                Console.WriteLine();
            }
        }
    }



    class CharP15
    {
        //pattern 37
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'E'; j > i; j--)
                {
                    Console.Write("A ");
                }
                for (char k = 'A'; k <= i; k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }


}
