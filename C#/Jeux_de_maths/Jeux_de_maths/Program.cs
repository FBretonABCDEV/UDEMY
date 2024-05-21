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

        static int CalculerPoints(int _reponseJoueur, int _result)
        {
            int nbPoints = 0;
            if (_reponseJoueur == _result)
            {
                Console.WriteLine("Bonne réponse.\n");
                nbPoints += 1;
            }
            else
            {
                Console.WriteLine("Mauvaise réponse.\n");
            }
            return nbPoints;
        }
        static void AfficherScore(int _nbPoints, int _questionMax)
        {
            Console.WriteLine("Nombre de points : " + _nbPoints + " / " + _questionMax);
            if (_nbPoints == _questionMax)
            {
                Console.WriteLine("Excellent !");
            }
            else if (_nbPoints == _questionMax / 2)
            {
                Console.WriteLine("C'est pas mal");
            }
            else if (_nbPoints < _questionMax / 2)
            {
                Console.WriteLine("Essayer de faire mieux la prochaine.");
            }
            else if (_nbPoints > _questionMax / 2)
            {
                Console.WriteLine("Pas mal.");
            }
        }


        /* FONCTIONS PRINCIPALE */
        public static void Main(String[] args)
        {
            /* CONSTRANTES */

            const int QUESTIONS_MAX = 5;

            /* VARIABLES */

            int reponseJoueur = 0, result = 0,  nbPoints = 0, numQuestion = 0;

            /* DEBUT PROGRAMME */

            //Commencer le questionnaire
            for (numQuestion = 1; numQuestion <= QUESTIONS_MAX; numQuestion++)
            {
                //Afficher le numéro de question
                Console.WriteLine("Question n°" + numQuestion + "/" + QUESTIONS_MAX + " :");


                //Générer et afficher opération
                result = GenererOperation();

                //Demander un résultat au joueur
                reponseJoueur = DemanderResultat();

                //Calculer nombre de points
                nbPoints = CalculerPoints(reponseJoueur, result);
            }

            //Afficher le score
            AfficherScore(nbPoints, QUESTIONS_MAX);

            /* FIN PROGRAMME */
        }
    }
}

