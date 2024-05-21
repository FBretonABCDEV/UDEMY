using System;

namespace Jeux_de_maths
{
    class Program
    {
        public static void Main(String[] args)
        {

            /* VARIABLES */

            int nb1 = 0, nb2 = 0, result = 0, reponseValide = 0; ;
            String operateur = "";

            /* DEBUT PROGRAMME */

            //Afficher la question 1
            Console.WriteLine("Question n°1/5 :");

            //cas 1 operateur -> +
            operateur = " + ";
            nb1 = 8; nb2 = 4; result = 0;
            result = nb1 + nb2;

            //Demander résultat
            Console.Write(nb1 + operateur + nb2 +" = ");
            int nbUtilisateur = int.Parse(Console.ReadLine());

            //Valider la réponse
            if(nbUtilisateur == result)
            {
                Console.WriteLine("Bonne réponse");
                reponseValide += 1;
            }
            else
            {
                Console.WriteLine("Mauvaise réponse.");
            }

            //Afficher la question 2
            Console.WriteLine("Question n°2/5 :");

            //cas 2 operateur -> -
            operateur = " - ";
            nb1 = 8; nb2 = 4; result = 0;
            result = nb1 - nb2;

            //Demander résultat
            Console.Write(nb1 + operateur + nb2 + " = ");
            nbUtilisateur = int.Parse(Console.ReadLine());

            //Valider la réponse
            if (nbUtilisateur == result)
            {
                Console.WriteLine("Bonne réponse");
                reponseValide += 1;
            }
            else
            {
                Console.WriteLine("Mauvaise réponse.");
            }

            //Afficher nombre bonnes réponses
            Console.WriteLine("nombre de bonne(s) réponse(s) : "+reponseValide);

            /* FIN PROGRAMME */
        }
    }
}

