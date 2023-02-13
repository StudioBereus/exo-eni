using System;

namespace exo_eni_4
{
    class Program
    {
        //Un film a coûté 150 millions d’euros. La première semaine, le film réalise une recette de 31 millions d’euros.
        //Chaque semaine qui passe, la recette est 20 % inférieure à celle de la semaine précédente.
        //Donnez l’algorithme qui permet d’indiquer au bout de combien de semaines le film est bénéficiaire.

        static void Main(string[] args)
        {
            double investissement = 150;
            double recette = 31;
            int nbSemaines = 0;
            while (investissement >= 0) 
            {
                nbSemaines++;
                investissement -= recette; 
                recette *= 0.8;
            }
            Console.WriteLine("Nombre de semaines avant que le film ne soit rentable : " + nbSemaines);
        }
    }
}
