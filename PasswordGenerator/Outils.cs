using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
     static class Outils
    {
        public static int DemanderNombrePositif(string question)
        {

            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR: Le nombre doit etre superieur à 1");
        }
        public static int DemanderNombreEntre(string question, int min, int max, string messagePers = null)
        {
            int number = DemanderNombre(question);

            if (number >= min && number <= max)
            {
                return number;
            }
            Console.WriteLine();
            if(messagePers == null)
            {
                Console.WriteLine("ERREUR ce nombre n'est pas valide, il doit etre compris entre " + min + " et " + max + " merci");
            }
            else
            {
                Console.WriteLine(messagePers);
            }
            return DemanderNombreEntre(question, min, max, messagePers);


        }
        public static int DemanderNombre(string question)
        {

            while (true)
            {
                Console.Write(question);
                string memory = Console.ReadLine();
                try
                {
                    int convert = int.Parse(memory);
                    return convert;

                }
                catch
                {
                    Console.WriteLine("Vous devez entrez un chiffre svp!");
                    Console.WriteLine();
                }
            }

        }

     }
}
