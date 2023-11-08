using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game_of_life
{
    class Program
    {
        static void Main(string[] args)
        {
            // Height and width of ground
            int h = 21;
            int w = 21;
            string[,] l1 = new string[h, w];
            int[,] l2 = new int[h, w];
            // l1[0, 0] = " *"; l1[0, 1] = " *"; l1[0, 2] = " *"; l1[0, 3] = " *"; l1[0, 4] = " *";l1[0, 5] = " *";
            // l1[1, 0] = " *"; l1[1, 1] = " *"; l1[1, 2] = " *"; l1[1, 3] = " *"; l1[1, 4] = " *";l1[1, 5] = " *";
            // l1[2, 0] = " *"; l1[2, 1] = " +"; l1[2, 2] = " +"; l1[2, 3] = " +"; l1[2, 4] = " *";l1[2, 5] = " *";
            // l1[3, 0] = " *"; l1[3, 1] = " *"; l1[3, 2] = " +"; l1[3, 3] = " +"; l1[3, 4] = " +";l1[3, 5] = " *";
            // l1[4, 0] = " *"; l1[4, 1] = " *"; l1[4, 2] = " *"; l1[4, 3] = " *"; l1[4, 4] = " *";l1[4, 5] = " *";
            // l1[5, 0] = " *"; l1[5, 1] = " *"; l1[5, 2] = " *"; l1[5, 3] = " *"; l1[5, 4] = " *";l1[5, 5] = " *";


            // Create random cell in ground
            Random x = new Random();
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    int a = x.Next(1, 2);
                    if (a == 1)
                    {
                        l1[i, j] = " +";
                    }
                    else
                        l1[i, j] = "  ";
                }
            }


            // Show ground in step 1:
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(l1[i, j]);

                }
                Console.WriteLine();
            }


            // Roles of game:
            for (; ; )
            {
                Thread.Sleep(100);
                Console.Clear();
                int nn = 0;
                int n = 0;

                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        if (l1[i, j] == " +")
                        {
                            if (i == 0 && (j != 0 && j != w - 1))
                            {
                                if (l1[i + 1, j] == " +")
                                    n++;
                                if (l1[h - 1, j] == " +")
                                    n++;
                                if (l1[i, j + 1] == " +")
                                    n++;
                                if (l1[i, j - 1] == " +")
                                    n++;
                                if (l1[i + 1, j + 1] == " +")
                                    n++;
                                if (l1[i + 1, j - 1] == " +")
                                    n++;
                                if (l1[h - 1, j + 1] == " +")
                                    n++;
                                if (l1[h - 1, j - 1] == " +")
                                    n++;
                            }

                            if (i == h - 1 && (j != 0 && j != w - 1))
                            {
                                if (l1[0, j] == " +")
                                    n++;
                                if (l1[i - 1, j] == " +")
                                    n++;
                                if (l1[i, j + 1] == " +")
                                    n++;
                                if (l1[i, j - 1] == " +")
                                    n++;
                                if (l1[0, j + 1] == " +")
                                    n++;
                                if (l1[0, j - 1] == " +")
                                    n++;
                                if (l1[i - 1, j + 1] == " +")
                                    n++;
                                if (l1[i - 1, j - 1] == " +")
                                    n++;
                            }

                            if (j == 0 && (i != 0 && i != h - 1))
                            {
                                if (l1[i + 1, j] == " +")
                                    n++;
                                if (l1[i - 1, j] == " +")
                                    n++;
                                if (l1[i, j + 1] == " +")
                                    n++;
                                if (l1[i, w - 1] == " +")
                                    n++;
                                if (l1[i + 1, j + 1] == " +")
                                    n++;
                                if (l1[i + 1, w - 1] == " +")
                                    n++;
                                if (l1[i - 1, j + 1] == " +")
                                    n++;
                                if (l1[i - 1, w - 1] == " +")
                                    n++;
                            }

                            if (j == w - 1 && (i != 0 && i != h - 1))
                            {
                                if (l1[i + 1, j] == " +")
                                    n++;
                                if (l1[i - 1, j] == " +")
                                    n++;
                                if (l1[i, 0] == " +")
                                    n++;
                                if (l1[i, j - 1] == " +")
                                    n++;
                                if (l1[i + 1, 0] == " +")
                                    n++;
                                if (l1[i + 1, j - 1] == " +")
                                    n++;
                                if (l1[i - 1, 0] == " +")
                                    n++;
                                if (l1[i - 1, j - 1] == " +")
                                    n++;
                            }

                            if (i == 0 && j == 0)
                            {
                                if (l1[i + 1, j] == " +")
                                    n++;
                                if (l1[h - 1, j] == " +")
                                    n++;
                                if (l1[i, j + 1] == " +")
                                    n++;
                                if (l1[i, w - 1] == " +")
                                    n++;
                                if (l1[i + 1, j + 1] == " +")
                                    n++;
                                if (l1[i + 1, w - 1] == " +")
                                    n++;
                                if (l1[h - 1, j + 1] == " +")
                                    n++;
                                if (l1[h - 1, w - 1] == " +")
                                    n++;
                            }

                            if (i == 0 && j == w - 1)
                            {
                                if (l1[0, 0] == " +")
                                    n++;
                                if (l1[h - 1, w - 1] == " +")
                                    n++;
                                if (l1[h - 1, 0] == " +")
                                    n++;
                                if (l1[i + 1, 0] == " +")
                                    n++;
                                if (l1[i + 1, j] == " +")
                                    n++;
                                if (l1[i + 1, j - 1] == " +")
                                    n++;
                                if (l1[i, j - 1] == " +")
                                    n++;
                                if (l1[h - 1, j - 1] == " +")
                                    n++;
                            }

                            if (i == h - 1 && j == w - 1)
                            {
                                if (l1[0, j] == " +")
                                    n++;
                                if (l1[i - 1, j] == " +")
                                    n++;
                                if (l1[i, 0] == " +")
                                    n++;
                                if (l1[i, j - 1] == " +")
                                    n++;
                                if (l1[0, 0] == " +")
                                    n++;
                                if (l1[0, j - 1] == " +")
                                    n++;
                                if (l1[i - 1, 0] == " +")
                                    n++;
                                if (l1[i - 1, j - 1] == " +")
                                    n++;
                            }

                            if (i == h - 1 && j == 0)
                            {
                                if (l1[0, j] == " +")
                                    n++;
                                if (l1[h - 1, j + 1] == " +")
                                    n++;
                                if (l1[i, w - 1] == " +")
                                    n++;
                                if (l1[i - 1, j] == " +")
                                    n++;
                                if (l1[i - 1, j + 1] == " +")
                                    n++;
                                if (l1[i - 1, w - 1] == " +")
                                    n++;
                                if (l1[0, j + 1] == " +")
                                    n++;
                                if (l1[0, w - 1] == " +")
                                    n++;
                            }

                            if (i != 0 && j != 0 && i != h - 1 && j != w - 1)
                            {
                                if (l1[i - 1, j - 1] == " +")
                                    n++;
                                if (l1[i - 1, j] == " +")
                                    n++;
                                if (l1[i - 1, j + 1] == " +")
                                    n++;
                                if (l1[i, j + 1] == " +")
                                    n++;
                                if (l1[i + 1, j + 1] == " +")
                                    n++;
                                if (l1[i + 1, j] == " +")
                                    n++;
                                if (l1[i + 1, j - 1] == " +")
                                    n++;
                                if (l1[i, j - 1] == " +")
                                    n++;
                            }

                            if (n == 2 || n == 3)
                                l1[i, j] = " +";
                            else
                                l1[i, j] = " *";
                            n = 0;
                        }


                        ///////////////////////////////////////////


                        if (l1[i, j] == " *")
                        {
                            if (i == 0 && (j != 0 && j != w - 1))
                            {
                                if (l1[i + 1, j] == " +")
                                    nn++;
                                if (l1[h - 1, j] == " +")
                                    nn++;
                                if (l1[i, j + 1] == " +")
                                    nn++;
                                if (l1[i, j - 1] == " +")
                                    nn++;
                                if (l1[i + 1, j + 1] == " +")
                                    nn++;
                                if (l1[i + 1, j - 1] == " +")
                                    nn++;
                                if (l1[h - 1, j + 1] == " +")
                                    nn++;
                                if (l1[h - 1, j - 1] == " +")
                                    nn++;
                            }

                            if (i == h - 1 && (j != 0 && j != w - 1))
                            {
                                if (l1[0, j] == " +")
                                    nn++;
                                if (l1[i - 1, j] == " +")
                                    nn++;
                                if (l1[i, j + 1] == " +")
                                    nn++;
                                if (l1[i, j - 1] == " +")
                                    nn++;
                                if (l1[0, j + 1] == " +")
                                    nn++;
                                if (l1[0, j - 1] == " +")
                                    nn++;
                                if (l1[i - 1, j + 1] == " +")
                                    nn++;
                                if (l1[i - 1, j - 1] == " +")
                                    nn++;
                            }

                            if (j == 0 && (i != 0 && i != h - 1))
                            {
                                if (l1[i + 1, j] == " +")
                                    nn++;
                                if (l1[i - 1, j] == " +")
                                    nn++;
                                if (l1[i, j + 1] == " +")
                                    nn++;
                                if (l1[i, w - 1] == " +")
                                    nn++;
                                if (l1[i + 1, j + 1] == " +")
                                    nn++;
                                if (l1[i + 1, w - 1] == " +")
                                    nn++;
                                if (l1[i - 1, j + 1] == " +")
                                    nn++;
                                if (l1[i - 1, w - 1] == " +")
                                    nn++;
                            }

                            if (j == w - 1 && (i != 0 && i != h - 1))
                            {
                                if (l1[i + 1, j] == " +")
                                    nn++;
                                if (l1[i - 1, j] == " +")
                                    nn++;
                                if (l1[i, 0] == " +")
                                    nn++;
                                if (l1[i, j - 1] == " +")
                                    nn++;
                                if (l1[i + 1, 0] == " +")
                                    nn++;
                                if (l1[i + 1, j - 1] == " +")
                                    nn++;
                                if (l1[i - 1, 0] == " +")
                                    nn++;
                                if (l1[i - 1, j - 1] == " +")
                                    nn++;
                            }

                            if (i == 0 && j == 0)
                            {
                                if (l1[i + 1, j] == " +")
                                    nn++;
                                if (l1[h - 1, j] == " +")
                                    nn++;
                                if (l1[i, j + 1] == " +")
                                    nn++;
                                if (l1[i, w - 1] == " +")
                                    nn++;
                                if (l1[i + 1, j + 1] == " +")
                                    nn++;
                                if (l1[i + 1, w - 1] == " +")
                                    nn++;
                                if (l1[h - 1, j + 1] == " +")
                                    nn++;
                                if (l1[h - 1, w - 1] == " +")
                                    nn++;
                            }

                            if (i == 0 && j == w - 1)
                            {
                                if (l1[0, 0] == " +")
                                    nn++;
                                if (l1[h - 1, w - 1] == " +")
                                    nn++;
                                if (l1[h - 1, 0] == " +")
                                    nn++;
                                if (l1[i + 1, 0] == " +")
                                    nn++;
                                if (l1[i + 1, j] == " +")
                                    nn++;
                                if (l1[i + 1, j - 1] == " +")
                                    nn++;
                                if (l1[i, j - 1] == " +")
                                    nn++;
                                if (l1[h - 1, j - 1] == " +")
                                    nn++;
                            }

                            if (i == h - 1 && j == w - 1)
                            {
                                if (l1[0, j] == " +")
                                    nn++;
                                if (l1[i - 1, j] == " +")
                                    nn++;
                                if (l1[i, 0] == " +")
                                    nn++;
                                if (l1[i, j - 1] == " +")
                                    nn++;
                                if (l1[0, 0] == " +")
                                    nn++;
                                if (l1[0, j - 1] == " +")
                                    nn++;
                                if (l1[i - 1, 0] == " +")
                                    nn++;
                                if (l1[i - 1, j - 1] == " +")
                                    nn++;
                            }

                            if (i == h - 1 && j == 0)
                            {
                                if (l1[0, j] == " +")
                                    nn++;
                                if (l1[h - 1, j + 1] == " +")
                                    nn++;
                                if (l1[i, w - 1] == " +")
                                    nn++;
                                if (l1[i - 1, j] == " +")
                                    nn++;
                                if (l1[i - 1, j + 1] == " +")
                                    nn++;
                                if (l1[i - 1, w - 1] == " +")
                                    nn++;
                                if (l1[0, j + 1] == " +")
                                    nn++;
                                if (l1[0, w - 1] == " +")
                                    nn++;
                            }

                            if (i != 0 && j != 0 && i != h - 1 && j != w - 1)
                            {
                                if (l1[i - 1, j - 1] == " +")
                                    nn++;
                                if (l1[i - 1, j] == " +")
                                    nn++;
                                if (l1[i - 1, j + 1] == " +")
                                    nn++;
                                if (l1[i, j + 1] == " +")
                                    nn++;
                                if (l1[i + 1, j + 1] == " +")
                                    nn++;
                                if (l1[i + 1, j] == " +")
                                    nn++;
                                if (l1[i + 1, j - 1] == " +")
                                    nn++;
                                if (l1[i, j - 1] == " +")
                                    nn++;
                            }

                            if (nn == 3)
                                l1[i, j] = " +";

                            nn = 0;

                        }
                    }
                }


                // Show ground in steps:
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        if (l1[i, j] == " *")
                            Console.Write("  ");
                        else
                            Console.Write(l1[i, j]);

                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}