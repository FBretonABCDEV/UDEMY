using System;

namespace Generateur_mot_de_passe
{
    class Program
    {
        /* FONCTIONS */

        static int DemanderNombre(string _question)
        {
            int nombre = 0;
            bool nbValide = false;
            while (!nbValide)
            {
                try
                {
                    //Tester si valeur numérique
                    Console.Write(_question);
                    nombre = int.Parse(Console.ReadLine());
                    nbValide = true;
                }
                catch
                {
                    Console.WriteLine("ERREUR : La valeur n'est pas un nombre.");
                    nbValide = false;
                }
            }
            return nombre;
        }
        static int DemandernombreEntre(string _question, int _min, int _max)
        {
            int nombre = 0;
            while (true)
            {
                nombre = DemanderNombre(_question);
                if(nombre >= _min && nombre <= _max)
                {
                    return nombre;
                }
                else
                {
                    Console.WriteLine("Vous devez choisir un nombre entre " + _min + " et " + _max + ".");
                }
            }
        }

        /* FONCTION PRINCIPALE */
        static void Main(string[] args)
        {
            //Demander la longueur du mot de passe
            //Définir l'alphabet
            //générer mot de passe

            DemandernombreEntre("Longueur du mot de passe : ", 5, 12);
        }
    }
}
