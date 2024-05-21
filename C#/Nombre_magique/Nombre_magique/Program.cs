using System;

namespace Nombre_magique
{
    public class program
    {
        /* FONCTIONS */
        static int DemanderNombre(int nbAleatoireMin, int nbAleatoireMax)
        {
            int nbUtilisateur = 0;
            while(nbUtilisateur == 0)
            {
                try
                {
                    nbUtilisateur = int.Parse(Console.ReadLine());
                    if (nbUtilisateur < nbAleatoireMin || nbUtilisateur > nbAleatoireMax)
                    {
                        Console.WriteLine("Vous devez entrer un nombre entre " + nbAleatoireMin +" et "+ nbAleatoireMax +" :\n");
                        nbUtilisateur = 0;
                    }
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez entrer un nombre.");

                }
            }
            return nbUtilisateur;
        }
        static void AfficherResultat(int message, int nbMin, int nbMax, int vie)
        {
            switch (message)
            {
                case 1:
                    Console.WriteLine("Le nombre magique est compris entre " + nbMin + " et " + nbMax + ".\n");
                    break;
                case 2:
                    Console.WriteLine("le nombre magique est compris entre " + nbMin + " et " + nbMax + ".\n");
                    break;
                case 3:
                    Console.WriteLine("bravo, vous avez trouvé le nombre magique !\n");
                    break;
                case 4:
                    Console.WriteLine("Vous avez perdu.\n");
                    break;
                default:
                    Console.WriteLine("Erreur choix impossible dans AfficherResultat()");
                    break;
            }
            //Afficher nombres de vies
            Console.WriteLine("Il vous reste : " + vie + " vie(s)\n");
        }

        /* FONCTION PRINCIPALE */
        public static void Main(string[] args)
        {
            /* VARIABLES */

            int nbJoueur;
            int nbMagique;
            int nbAleatoireMin = 1;
            int nbAleatoireMax = 10;
            int nbVie = 5;
            bool finPartie = false;
            int message = 0;

            /* DEBUT PROGRAMME */

            //Définir nombre entier aleatoire entre 1 et 10
            Random nbAleatoire = new Random();
            nbMagique = nbAleatoire.Next(nbAleatoireMin, nbAleatoireMax);
            Console.WriteLine(nbMagique);
            Console.WriteLine("LE NOMBRE MAGIQUE\n\nVous avez "+ nbVie +" vies.\nEntrer un nombre entre " + nbAleatoireMin +
                              " et "+ nbAleatoireMax +" :\n");

            do
            {
                //Demander un nombre entre entre 1 et 10
                nbJoueur = DemanderNombre(int nbAleatoireMin,int nbAleatoireMax);
                nbVie -= 1;

                //Déterminer le résultat
                if (nbJoueur < nbMagique)
                {
                    if(nbJoueur > nbAleatoireMin)
                    {
                        nbAleatoireMin = nbJoueur;
                    }
                    message = 1;
                }
                else if (nbJoueur > nbMagique)
                {
                    if(nbJoueur < nbAleatoireMax)
                    {
                        nbAleatoireMax = nbJoueur;
                    }
                    message = 2;
                }
                else if (nbJoueur == nbMagique)
                {
                    message = 3;
                    finPartie = true;
                }
                //Partie perdue
                if (nbVie <= 0 && nbJoueur != nbMagique)
                {
                    message = 4;
                    finPartie = true;
                }
                //Sélectionner le message qui doit être afficher
                AfficherResultat(message, nbAleatoireMin, nbAleatoireMax, nbVie);

            } while (!finPartie);


           
            /* FIN PROGRAMME */
        }
    }
}
