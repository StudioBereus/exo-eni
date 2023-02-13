using System;

namespace exo_eni_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Avec une structure tant que, faire un algorithme qui effectue une multiplication par addition successives 
            Console.WriteLine("Veuillez indiquer deux chiffres");
            string[] rep = Console.ReadLine().Split(' ');
            if(int.TryParse(rep[0], out int a) && int.TryParse(rep[1], out int b)){
                int res = 0;
                while (b != 0)
                {
                    res += a;
                    b--;
                }
                Console.WriteLine(res);
            }
        }
    }
}
