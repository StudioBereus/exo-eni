using System;

namespace exo_eni
{
    class Program
    {
        //Afficher les nombres pairs de 1 a 10
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++) 
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
