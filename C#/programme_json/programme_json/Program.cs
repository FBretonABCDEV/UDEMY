using Newtonsoft.Json;
using System;

namespace programme_json
{
    class Personne
    {
        public string nom { get; private set; }
        public int age { get; private set; }
        public bool majeur { get; private set; }

        public Personne(string nom,int age, bool majeur)
        {
            this.nom = nom;
            this.age = age;
            this.majeur = majeur;
        }
        public void Afficher()
        {
            Console.WriteLine(" - Nom : " + this.nom + " - Age : " + this.age + "ans");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Personne personne1 = new Personne("toto", 20, true);

            personne1.Afficher();

            //Sérialisation d'un objet
            string jsonToto = JsonConvert.SerializeObject(personne1);
            Console.WriteLine(jsonToto);

            //Déserialisation d'un json
            string jsonTiti = "{\"nom\":\"titi\",\"age\":15,\"majeur\":false}";
            Personne titi  = JsonConvert.DeserializeObject<Personne>(jsonTiti);

            titi.Afficher();
        }
    }
}
