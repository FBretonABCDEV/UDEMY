using System;

namespace Fichier_performances
{
    class program
    {
        static void Main(string[] args)
        {
            //Ecrire une liste de noms
            string fileName = "fichierPerformances.txt";
            string texte = "";
            int nbLignes = 20000;

            Console.Write("Préparation des données...");

            for (int i = 1; i <= nbLignes; i++)
            {
                texte += "Ligne " + i + "\n";
            }

            Console.WriteLine("OK");

            Console.Write("Ecriture des données...");

            File.WriteAllText(fileName, texte);

            Console.WriteLine("OK");

            //Gestion d'exceptions fichierNoms.txt
            /*try
            {
                //Afficher chaque string de la liste
                var result2 = File.ReadAllLines(fileName);
                foreach (string nom in result2)
                {
                    Console.WriteLine(nom);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Erreur ce fichier n'existe pas (" + ex.Message + ")");
            }
            catch
            {
                Console.WriteLine("Une erreur inconnue est arrivée");
            }*/

        }
    }
}
