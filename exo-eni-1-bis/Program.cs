using System;

namespace exo_eni_1_bis
{
    class Program
    {
        //Afficher les nombres impairs entre 1 et 10
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 1) 
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
