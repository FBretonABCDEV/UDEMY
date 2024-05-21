using System;

namespace Jeux_de_maths
{
    class Program
    {
        public static void Main(String[] args)
        {

            /* VARIABLES */

            const int QUESTIONS_MAX = 5;

            int nb1 = 0, nb2 = 0, result = 0, reponseValide = 0, numQuestion = 0;
            String operateur = "";

            /* DEBUT PROGRAMME */

            for(numQuestion = 1; numQuestion <= QUESTIONS_MAX; numQuestion++)
            {
                //Afficher la question
                Console.WriteLine("Question n°" + numQuestion + "/" + QUESTIONS_MAX + " :");

                //cas 1 operateur -> +
                operateur = " + ";
                nb1 = 8; nb2 = 4; result = 0;
                result = nb1 + nb2;

                //Demander résultat
                Console.Write(nb1 + operateur + nb2 + " = ");
                int nbUtilisateur = int.Parse(Console.ReadLine());

                //Valider la réponse
                if (nbUtilisateur == result)
                {
                    Console.WriteLine("Bonne réponse.\n");
                    reponseValide += 1;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse.\n");
                }
            }
            Console.WriteLine("Nombre de points : "+reponseValide+" / "+QUESTIONS_MAX);

            /* FIN PROGRAMME */
        }
    }
}

