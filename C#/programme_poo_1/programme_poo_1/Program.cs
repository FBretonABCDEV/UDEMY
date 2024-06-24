using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace programme_poo_1
{
    class Etudiant : Personne
    {
        //Variables d'instance
        private string infoEtudiant;

        //Constructeur
        public Etudiant(String nom, int age, string infoEtudiant) : base(nom, age)
        {
            this.infoEtudiant = infoEtudiant;
        }

        //méthodes
        public override void Afficher()
        {
            AfficherNomEtAge();
            Console.WriteLine("  Etudiant en : " + infoEtudiant);
        }
    }
    class Personne
    {
        //Variable de class
        private static int nombrePersonnes;//static variable commune à toutes les instances

        //variable d'instance
        protected string nom;
        protected int age;
        private string emploi;
        protected int numeroPersonne = 0;

        //Constructeur
        public Personne(string nom, int age, string emploi = null)
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;
            nombrePersonnes++;
            this.numeroPersonne = nombrePersonnes;
        }

        //Méthodes static (utiliser avec la class Personne.AfficherPersonnes();)
        public static void AfficherNombrePersonnes()
        {
            Console.WriteLine("Nombre total de personnes : " + nombrePersonnes);
        }

        //méthodes
        protected void AfficherNomEtAge()
        {
            Console.WriteLine("Personne N° " + numeroPersonne);
            Console.WriteLine("  NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
        }
        public virtual void Afficher()
        {
            AfficherNomEtAge();
            if (this.emploi == null)
            {
                Console.WriteLine("  non spécifié");
            }
            else
            {
                Console.WriteLine("  EMPLOI : " + emploi);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //liste de Class Personne
            List<Personne> listeCivile = new List<Personne>();
            listeCivile.Add(new Personne("Edouard", 28, "Mécanicien"));
            listeCivile.Add(new Personne("Nathalie", 42, "Secrétaire"));
            listeCivile.Add(new Personne("Pauline", 18, "Etudiant"));
            listeCivile.Add(new Personne("Nicolas", 8, "CP"));
            listeCivile.Add(new Personne("juliette", 24));
            listeCivile.Add(new Personne("lucas", 21));

            listeCivile.Add(new Etudiant("David", 22, "Ecole d'informatique"));

            //Afficher chaque personne de la liste
            foreach (Personne element in listeCivile)
            {
                element.Afficher();
                Console.WriteLine();
            }

            Personne.AfficherNombrePersonnes();
        }
    }
}