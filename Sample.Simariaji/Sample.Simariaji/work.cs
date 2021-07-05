using System;
namespace Sample.Simariaji
{
    public class Work
    {
        public static void star()
        {
        
            for (int i = 0 ; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine(" ");
            }            

        }
    }
}
