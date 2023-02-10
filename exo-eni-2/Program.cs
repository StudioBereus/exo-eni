using System;

namespace exo_eni_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculer la somme de tous les chiffres précédent un chiffre donné
            Console.WriteLine("Veuillez indiquer un nombre entier");
            if(int.TryParse(Console.ReadLine(), out int number))
            {
                int sum = 0;
                for (int i = 0; i < number + 1; i++) 
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
