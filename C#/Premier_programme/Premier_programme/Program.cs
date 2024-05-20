using System;

namespace Premier_programme
{
    public class Program
    {
        public static void Main(String[] args)
        {
            /* VARIABLES */

            String nom;
            int age = 0;

            /* DEBUT PROGRAMME */

            Console.WriteLine("Quel est ton nom ?");
            nom = Console.ReadLine();
            while(age <= 0)
            {
                try
                {
                    Console.WriteLine("Quel ton âge ?");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age + " ans.");
                    age += 1;
                    Console.WriteLine("Bientôt vous aurez " + age + " ans");
                }
                catch
                {
                    Console.WriteLine("Erreur. Vous devez entrer un âge valide.");
                }
            }
            
            /* FIN PROGRAMME */
        }
    }
}