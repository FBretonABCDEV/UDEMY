using System;

namespace Collection
{
    class Program
    {
        /* FONCTIONS */
        static void AfficherTableau(int[] _tableau)
        {
            for (int i = 0; i < _tableau.Length; i++)
            {
                Console.WriteLine("[" + i + "]" + "  " + _tableau[i]);
            }
        }

        /* FONCTION PRINCIPALE */
        public static void Main(string[] args)
        {
            //int[] monTableau = new int[] { 200, 40, 15, 8, 12 };
            
            const int TAILLE_TABLEAU = 12;
            
            int[] t = new int[TAILLE_TABLEAU];

            //Initialisation tableau valeurs aléatoires 0 à 100
            Random aleatoire = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = aleatoire.Next(101);
            }
            AfficherTableau(t);
        }
    }
}
