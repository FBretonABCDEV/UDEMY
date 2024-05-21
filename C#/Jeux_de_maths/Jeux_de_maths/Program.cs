using System;

namespace Jeux_de_maths
{
    class Program
    {
        /* FONCTIONS */

        static int GenererOperation()
        {
            Random nbAleatoire = new Random();
            bool operationInvalide = false;
            string operateur = " + ";
            int nb1, nb2, op, result = 0;
            do
            {
                nb1 = nbAleatoire.Next(1, 10);
                nb2 = nbAleatoire.Next(1, 10);
                op = nbAleatoire.Next(4);

                switch (op)
                {
                    case 0:
                        result = nb1 + nb2;
                        operateur = " + ";
                        break;
                    case 1:
                        result = nb1 - nb2;
                        operateur = " - ";
                        if(result < 0)
                        {
                            operationInvalide = true;
                        }
                        else
                        {
                            operationInvalide = false;
                        }
                        break;
                    case 2:
                        result = nb1 * nb2;
                        operateur = " * ";
                        break;
                    case 3:
                        if (nb1 % nb2 != 0)
                        {
                            operationInvalide = true;
                        }
                        else
                        {
                            result = nb1 / nb2;
                            operateur = " / ";
                            operationInvalide = false;
                        }
                        break;
                    default:
                        Console.WriteLine("ERREUR : Opération non générer.");
                        break;
                }
            } while (operationInvalide);
            
            Console.Write(nb1 + operateur + nb2 + " = ");
            return result;
        }
        static int DemanderResultat()
        {
            int nbUtilisateur = 0;
            bool nbValide = false;
            while (!nbValide)
            {
                try
                {
                    nbUtilisateur = int.Parse(Console.ReadLine());
                    nbValide = true;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez entrer un nombre.\n");
                }
            }
            
            return nbUtilisateur;
        }
        

        /* FONCTIONS PRINCIPALE */
        public static void Main(String[] args)
        {
            /* CONSTRANTES */

            const int QUESTIONS_MAX = 5;

            /* VARIABLES */

            int reponseJoueur = 0, result = 0,  nbPoints = 0, numQuestion = 0;

            /* DEBUT PROGRAMME */

            for (numQuestion = 1; numQuestion <= QUESTIONS_MAX; numQuestion++)
            {
                //Afficher le numéro de question
                Console.WriteLine("Question n°" + numQuestion + "/" + QUESTIONS_MAX + " :");


                //Générer et afficher opération
                result = GenererOperation();

                //Demander un résultat au joueur
                reponseJoueur = DemanderResultat();

                //Calculer nombre de points
                if (reponseJoueur == result)
                {
                    Console.WriteLine("Bonne réponse.\n");
                    nbPoints += 1;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse.\n");
                }
            }

            //Afficher le score
            Console.WriteLine("Nombre de points : "+nbPoints+" / "+QUESTIONS_MAX);
            if(nbPoints == QUESTIONS_MAX / 2)
            {
                Console.WriteLine("Pas mal");
            }
            if (nbPoints < QUESTIONS_MAX / 2)
            {
                Console.WriteLine("Essayer de faire mieux la prochaine.");
            }
            if (nbPoints > QUESTIONS_MAX / 2)
            {
                Console.WriteLine("Excellent");
            }

            /* FIN PROGRAMME */
        }
    }
}

