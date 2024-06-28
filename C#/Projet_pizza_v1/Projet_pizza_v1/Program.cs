using System;

namespace projet_pizza_v1
{
    class Program
    {
        class Pizza
        {
            //variables d'instance
            string nom;
            float prix;
            bool vegetarienne;

            //constructeur
            public Pizza(string nom, float prix, bool vegetarienne = false)
            {
                this.nom = nom;
                this.prix = prix;
                this.vegetarienne = vegetarienne;
            }

            public void Afficher()
            {
                /*string vegan = "";
                if (this.vegetarienne)
                {
                    vegan = " (V)";
                }*/

                //alternative notation condition if peu volumineuse
                string vegan = vegetarienne ? " (V)" : "";

                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine(this.nom + vegan + " - " + prix + "€");
            }
        }
        static void Main(string[] Args)
        {
            //class Pizza
            //nom(4 fromages)
            //prix 11.5
            //vegetarienne(vrai ou faux)
            //constructeur
            //Afficher
            //4 fromages (V) - 11.5€
            //créer une liste de pizzas
            //boucler pour afficher les pizzas

            List<Pizza> listePizzas = new List<Pizza>() 
                                        { 
                                            new Pizza("4 fromages", 11.5f, true),
                                            new Pizza("indienne", 10.5f, false),
                                            new Pizza("royale", 13f, false),
                                            new Pizza("margherita", 8f, true),
                                            new Pizza("calzone", 12f, false),
                                            new Pizza("complète", 9.5f, false)
                                        };
            foreach(var element in listePizzas)
            {
                element.Afficher();
            }
        }
    }
}
