using System;
using FormationCS;

namespace FormationCS
{
    class Program
    {
        /* FONCTIONS */

        static string GenererMotPasse(string _alphabet, int _longueurMotPasse)
        {
            string motDePasse = "";
            Random aleatoire = new Random();

            for (int i = 0; i < _longueurMotPasse; i++)
            {
                int nbAleatoire = aleatoire.Next(_alphabet.Length);
                motDePasse += _alphabet[nbAleatoire];
            }
            return motDePasse;
        }

        /* FONCTION PRINCIPALE */
        static void Main(string[] args)
        {
            //Demander la longueur du mot de passe
            //Définir l'alphabet
            //générer mot de passe
            
            int longMotPasse = outils.DemanderNombrePositifNonNul("longueur du mot de passe : ");
            string alphabetMin = "abcdefghijklmnopqrstuvwxyz";
            string motDePasse = GenererMotPasse(alphabetMin, longMotPasse);
            Console.WriteLine(motDePasse);
        }
    }
}
