using System;
using FormationCS;

namespace FormationCS
{
    class Program
    {
        /* FONCTIONS */

        static bool DemanderChoixBinaire(string _question)
        {
            string choix = "";
            Console.Write(_question);
            choix = Console.ReadLine();
            if (choix.Equals("oui", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else if (choix.Equals("non", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            else
            {
                return DemanderChoixBinaire(_question);
            }
        }
        static string GenererMotPasse()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz0123456789 !\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            int longueurMotPasse = outils.DemanderNombrePositifNonNul("longueur du mot de passe : ");

            bool ajouterMin = DemanderChoixBinaire("Mot de passe avec minuscules : ");
            bool ajouterMaj = DemanderChoixBinaire("Mot de passe avec majuscules : ");
            bool ajouterNb = DemanderChoixBinaire("Mot de passe avec nombres : ");
            bool charSpeciaux = DemanderChoixBinaire("Mot de passe avec caractères spéciaux : ");

            string motDePasse = "";
            Random aleatoire = new Random();
            while(motDePasse.Length < longueurMotPasse)
            {
                for (int i = 0; i < longueurMotPasse; i++)
                {
                    int nbAleatoire = aleatoire.Next(alphabet.Length);
                    string caractere = alphabet[nbAleatoire].ToString();
                    int aleatoireMaj = aleatoire.Next(11);

                    if (nbAleatoire < 26)
                    {
                        if (ajouterMin && !ajouterMaj)
                        {
                            motDePasse += caractere;
                        }
                        if (ajouterMaj && !ajouterMin)
                        {
                            motDePasse += caractere.ToUpper();
                        }
                        if(ajouterMin && ajouterMaj)
                        {
                            if(aleatoireMaj%2 == 0)
                            {
                                motDePasse += caractere.ToUpper();
                            }
                            else
                            {
                                motDePasse += caractere;
                            }
                        }
                    }
                    
                    if (nbAleatoire > 25 && nbAleatoire < 36 && ajouterNb)
                    {
                        motDePasse += alphabet[nbAleatoire];
                    }
                    if (nbAleatoire > 35 && charSpeciaux)
                    {
                        motDePasse += alphabet[nbAleatoire];
                    }
                }
            }
            return motDePasse;
        }

        /* FONCTION PRINCIPALE */
        static void Main(string[] args)
        {
            //Demander la longueur du mot de passe
            //Définir l'alphabet
            //générer mot de passe
            bool quitter = false;
            while (!quitter)
            {
                string quitterStr = "";

                //Générer et afficher le mot de passe
                string motDePasse = GenererMotPasse();
                Console.WriteLine("Mot de passe : " + motDePasse + "\n");

                //Continuer ou quitter
                Console.WriteLine("Appuyer sur q pour quitter ou n'importe quelle touche pour continuer.");
                quitterStr = Console.ReadLine();

                if (quitterStr.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    quitter = true;
                }
            }


        }
    }
}
