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
                Console.WriteLine(_tableau[i]);
            }
        }

        /* FONCTION PRINCIPALE */
        public static void Main(string[] args)
        {
            int[] monTableau = new int[] {200, 40, 15, 8, 12};
            
            AfficherTableau(monTableau);
        }
    }
}
