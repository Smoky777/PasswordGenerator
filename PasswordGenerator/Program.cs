
namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NB_DE_MOT = 10;
            int longueurPassword = Outils.DemanderNombrePositif("Choisissez la taille de votre mot de passe: ");
            Console.WriteLine();
            int ChoixMotPasse = Outils.DemanderNombreEntre("Vous voulez un mot de passe avec :\n" +
                "1- Uniquement des caracteres en minuscule\n" +
                "2- Des caracteres minuscule et majuscule\n" +
                "3- Des caracteres et des chiffres\n" +
                "4- Caracteres, chiffres et caracteres spéciaux\n" +
                "Votre Choix: ", 1, 4);
            Console.WriteLine();

            string minuscule = "abcdefghijklmnopqrstuvwxyz";
            string majuscule = minuscule.ToUpper();
            string chiffre = "0123456789";
            string special = "&@!?/:$£-+=#";
            string alphabet = minuscule + majuscule + chiffre + special;
            string minMaj = minuscule + majuscule;
            string specar = special + chiffre;
            string motDePasse = "";

            int l = alphabet.Length;
            int m = minMaj.Length;
            int n= specar.Length;
            int o = minuscule.Length;

            for(int a = 0; a < NB_DE_MOT; a++)
            {
                motDePasse = "";
                switch (ChoixMotPasse)
                {
                    case 1:
                        for (int i = 0; i < longueurPassword; i++)
                        {
                            Random rand = new Random();
                            int r = rand.Next(0, o);
                            motDePasse += minuscule[r];

                        }
                        break;

                    case 2:
                        for (int i = 0; i < longueurPassword; i++)
                        {
                            Random rand = new Random();
                            int r = rand.Next(0, m);
                            motDePasse += minMaj[r];

                        }
                        break;

                    case 3:
                        for (int i = 0; i < longueurPassword; i++)
                        {
                            Random rand = new Random();
                            int r = rand.Next(0, n);
                            motDePasse += specar[r];

                        }
                        break;

                    case 4:
                        for (int i = 0; i < longueurPassword; i++)
                        {
                            Random rand = new Random();
                            int r = rand.Next(0, l);
                            motDePasse += alphabet[r];

                        }
                        break;
                }
                Console.Write("Mot De Passe: " + motDePasse + "\n");
                Console.WriteLine();
            }
            Console.WriteLine("Vous pouvez choisir un Mot De Passe :) ");
        }   

    }   
}