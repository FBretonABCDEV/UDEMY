using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace programme_poo
{
    class Personne
    {
        //Variable de class
        public static int nombrePersonnes;//static variable commune à toutes les instances

        //variable d'instance
        public string nom;
        private int age;
        private string emploi;
        private int numeroPersonne = 0;

        //Constructeur
        public Personne(string _nom, int _age, string _emploi)
        {
            this.nom = _nom;
            this.age = _age;
            this.emploi = _emploi;

            nombrePersonnes++;

            this.numeroPersonne = nombrePersonnes;
        }

        public void Afficher()
        {
            Console.WriteLine("Personne N° " + numeroPersonne);
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
            Console.WriteLine("  EMPLOI : " + emploi);
        }
    }

    class Program
    {
        /*static void AfficherInfosPersonne(string nom, int age, string emploi)
        {
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
            Console.WriteLine("  EMPLOI : " + emploi);
        }*/

        static void Main(string[] args)
        {
            // nom, age, emploi
            /*var noms = new List<string> { "Paul", "Jacques", "David", "Juliette" };
            var ages = new List<int> { 30, 35, 20, 8 };
            var emplois = new List<string> { "Développeur", "Professeur", "Etudiant", "CP" };

            for (int i = 0; i < noms.Count; i++)
            {
                AfficherInfosPersonne(noms[i], ages[i], emplois[i]);
            }

            Personne personne1 = new Personne("Paul", 30, "Développeur");
            personne1.Afficher();

            Personne personne2 = new Personne("Jacques", 35, "Professeur");
            personne2.Afficher();*/

            //liste de Class Personne
            List<Personne> listeCivile = new List<Personne>();
            listeCivile.Add(new Personne("Edouard", 28, "Mécanicien"));
            listeCivile.Add(new Personne("Nathalie", 42, "Secrétaire"));
            listeCivile.Add(new Personne("Pauline", 18, "Etudiant"));
            listeCivile.Add(new Personne("Nicolas", 8, "CP"));

            //Trier par nom
            //listeCivile = listeCivile.OrderBy(p => p.nom).ToList();

            //Afficher chaque personne de la liste
            foreach(Personne element in listeCivile)
            {
                element.Afficher();
                Console.WriteLine();
            }
            Console.WriteLine("Nombre total de personnes : " + Personne.nombrePersonnes);
        }
    }
}
