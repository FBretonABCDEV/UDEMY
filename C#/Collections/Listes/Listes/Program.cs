using System;
using System.ComponentModel;

namespace Listes
{
    class Program
    {
        /* FONCTIONS */

        static void liste()
        {
            List<string> listeNoms = new List<string>();

            while (true)
            {
                Console.Write("Entrer un nom (Appuyer sur enter pour finir): ");
                string nom = Console.ReadLine();
                if (nom == "")
                {
                    break;
                }
                listeNoms.Add(nom);
            }
            //Filtrer : Supprimer les noms qui terminent par le caractère 'e'
            for (int i = 0; i < listeNoms.Count; i++)
            {
                if (listeNoms[i][listeNoms[i].Length-1] == 'e')
                {
                    listeNoms.RemoveAt(i);
                }
            }
            AfficherListe(listeNoms, true);
        }
        static void AfficherListe(List<string> _liste, bool ordreDescendant)
        {
            Console.WriteLine("\nLaliste des noms est : \n");
            if(!ordreDescendant)
            {
                for (int i = 0; i < _liste.Count; i++)
                {
                    Console.WriteLine("     - " + _liste[i]);
                }
            }
            else
            {
                for (int i = _liste.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine("     " + _liste[i]);
                }
            }
            //Afficher le nom le plus grand
            string nomPlusGrand = _liste[0];
            for (int i = 0; i < _liste.Count; i++)
            {
                if(nomPlusGrand.Length < _liste[i].Length)
                {
                    nomPlusGrand = _liste[i];
                }
            }
            Console.WriteLine("\nLe nom le plus grand de la liste est : " + nomPlusGrand);
        }

        /* FONCTION PRINCIPALE */
        public static void Main(string[] args)
        {
            liste();
        }
    }
}
