using System;
using FormationCS;

namespace FormationCS
{
    class Program
    {
        

        /* FONCTION PRINCIPALE */
        static void Main(string[] args)
        {
            //Demander la longueur du mot de passe
            //Définir l'alphabet
            //générer mot de passe

            outils.DemanderNombreEntre("Longueur du mot de passe : ", 5, 12);
            outils.DemanderNombrePositifNonNul("Choisir un nombre supérieur à 0 : ");
        }
    }
}
