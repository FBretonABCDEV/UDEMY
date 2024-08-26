using Newtonsoft.Json;
using System;

namespace programme_json
{
    class Personne
    {
        public string nom;
        public int age;
        public bool majeur;

        public void Afficher()
        {
            Console.WriteLine(" - Nom : " + this.nom + " - Age : " + this.age + "ans");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Personne personne1 = new Personne();
            personne1.nom = "toto";
            personne1.age = 20;
            personne1.majeur = true;

            personne1.Afficher();

            string jsonToto = JsonConvert.SerializeObject(personne1);
            Console.WriteLine(jsonToto);

            string jsonTiti = "{\"nom\":\"titi\",\"age\":15,\"majeur\":false}";
            Personne titi  = JsonConvert.DeserializeObject<Personne>(jsonTiti);

            titi.Afficher();
        }
    }
}
