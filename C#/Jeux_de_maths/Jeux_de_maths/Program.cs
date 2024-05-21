using System;

namespace Jeux_de_maths
{
    class Program
    {
        public static void Main(String[] args)
        {

            /* VARIABLES */

            int nb1 = 0, nb2 = 0, result = 0;
            String operateur = " + ";

            /* DEBUT PROGRAMME */

            //Afficher la question
            Console.WriteLine("Question n°1/5 :");

            //cas 1 operateur -> +
            nb1 = 8; nb2 = 4; result = 0;
            result = nb1 + nb2;

            //Demander résultat
            Console.Write(nb1 + operateur + nb2 +" = ");
            int nbUtilisateur = int.Parse(Console.ReadLine());

            if(nbUtilisateur == result)
            {
                Console.WriteLine("Bonne réponse");
            }
            else
            {
                Console.WriteLine("Mauvaise réponse.");
            }

            /* FIN PROGRAMME */
        }
    }
}

