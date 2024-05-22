using System;

namespace Generateur_mot_de_passe
{
    class Program
    {
        /* FONCTIONS */

        static int DemanderNombre(string _question)
        {
            int nombre = 0;
            while (true)
            {
                try
                {
                    //Tester si valeur numérique
                    Console.Write(_question);
                    nombre = int.Parse(Console.ReadLine());
                    return nombre;
                }
                catch
                {
                    Console.WriteLine("ERREUR : La valeur n'est pas un nombre.");
                }
            }
        }
        static int DemanderNombreEntre(string _question, int _min, int _max)
        {
            int nombre = 0;

            nombre = DemanderNombre(_question);
            if(nombre >= _min && nombre <= _max)
            {
                return nombre;
            }
            else
            {
                Console.WriteLine("Vous devez choisir un nombre entre " + _min + " et " + _max + ".");
                return DemanderNombreEntre(_question, _min, _max);
            }
        }

        static int DemanderNombrePositifNonNul(string _question)
        {
            return DemanderNombreEntre(_question, 1 , int.MaxValue);
        }

        /* FONCTION PRINCIPALE */
        static void Main(string[] args)
        {
            //Demander la longueur du mot de passe
            //Définir l'alphabet
            //générer mot de passe

            DemanderNombreEntre("Longueur du mot de passe : ", 5, 12);
            DemanderNombrePositifNonNul("Choisir un nombre supérieur à 0 : ");
        }
    }
}
