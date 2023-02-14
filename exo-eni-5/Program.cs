using System;

namespace exo_eni_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Écrire un algorithme qui convertit un nombre entier décimal en binaire
            string binary = "";
            Console.WriteLine("Veuillez entrer un nombre entier");
            if (int.TryParse(Console.ReadLine(), out int number)){
                while (number != 0)
                {
                    if (number % 2 == 0)
                    {
                        binary = 0 + "" + binary;
                    }
                    else
                    {
                        binary = 1 + "" + binary;
                    }
                    number /= 2;
                }
            }
            Console.WriteLine(binary);
        }
    }
}
