using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace programme_fichiers
{
    class program
    {
        static void Main(string[] args)
        {
            //Ecrire ou écraser le contenu
            string fileName1 = "monFichier.txt";
            File.WriteAllText(fileName1, "Voici mon premier texte que j'écris dans monFichier.txt");

            //Rajouter du texte
            File.AppendAllText(fileName1, " Je rajoute du texte.");
            File.AppendAllText(fileName1, " Je rajoute du texte.");

            //Ecrire une liste de noms
            string fileName2 = "fichierNoms.txt";
            var noms = new List<string>() 
            { "Paul", 
              "Henry", 
              "Grégoire" 
            };

            File.WriteAllLines(fileName2, noms);

            //Gestion d'exceptions monFichier.txt
            try
            {
                //afficher le texte
                string result1 = File.ReadAllText(fileName1);
                Console.WriteLine(result1);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Erreur ce fichier n'existe pas (" + ex.Message + ")");
            }
            catch
            {
                Console.WriteLine("Une erreur inconnue est arrivée");
            }

            //Gestion d'exceptions fichierNoms.txt
            try
            {
                //Afficher chaque string de la liste
                var result2 = File.ReadAllLines(fileName2);
                foreach(string nom in result2)
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
            }
        }
    }
}
