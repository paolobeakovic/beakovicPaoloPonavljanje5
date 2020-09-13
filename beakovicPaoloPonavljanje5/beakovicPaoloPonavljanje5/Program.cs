using System;

namespace beakovicPaoloPonavljanje5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 40; i++)
            {
                for (int j = 1; j < 40; j++)
                {
                    if (i != j)
                    {
                        for (int a = 1; a < 40; a++)
                        {
                            if (i != a && j != a)
                            {
                                for (int b = 1; b < 40; b++)
                                {
                                    if (i != b && j != b && a != b)
                                    {

                                        for (int c = 1; c < 40; c++)
                                        {
                                            if (i != c && j != c && a != c && b != c)
                                                for (int d = 1; d < 40; d++)
                                                {
                                                    if (i != d && j != d && a != d && b != d && c != d)
                                                    {
                                                    
                                                        for (int e = 1; e < 40; e++)
                                                        {


                                                        if (i != e && j != e && a != e && b != e && c != e && d != e)
                                                            {

                                                                Console.WriteLine(i + " " + j + " " + a + " " + b + " " + c + " " + d + " " + e);
                                                            }
                                                        }
                                                    }
                                                }
                                                }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
 Console.ReadKey();
        }
    }
}