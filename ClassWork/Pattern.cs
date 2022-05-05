using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }


    class Pattern1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)                             
            {
                for (int j = 1; j <= i; j++)                             
                {
                    if(j%2==1)
                    Console.Write("*");
                    else
                        Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern2
    {
        static void Main(string[] args)
        {
            int k;
            for(int i=1;i<=5;i++)
            {
                k = 1;
                for(int j=i;j>=1;j--)
                {
                    if(i%2==0)
                        Console.Write(j);
                    else
                    {
                        Console.Write(k);
                        k++;
                    }
                }
                Console.WriteLine();
            }
        }
    }


    class Pattern3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int space=1;space<=5;space++)
                {
                    Console.Write("-");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
        }
    }

    class Pattern4
    {
      static void Main(string[] args)
        {
            for(int i=1;i<=9;i=i+2)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern5
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=9;i=i+2)
            {
                for(int space=1;space<=(9-i)/2;space++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number rows");
            int numofrows = Convert.ToInt32(Console.ReadLine());

            for(int r=1;r<=numofrows;r++)
            {
                for(int space=1;space<=numofrows-r;space++)
                {
                    Console.Write(" ");
                }
                for(int c=1;c<=2*r-1;c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }


    class Pattern7
    {
        static void Main(string[] args)
        {
            for(int r=1;r<=5;r++)
            {
                for(int c=1;c<=5;c++)
                {
                    if(c==1 || r==1 || r==3 || (r<=3 && c==5))
                    
                        Console.Write("*");
                        else
                            Console.Write(" ");
                    
                }
                Console.WriteLine();
            }
        }
    }



}
