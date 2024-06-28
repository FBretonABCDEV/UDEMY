﻿using System;

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
                string nomAfficher = PremiereLettreMajuscule(this.nom);
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine(nomAfficher + vegan + " - " + prix + "€");
            }

            private static string PremiereLettreMajuscule(string s)
            {
                /*Notation alternative condition string vide ou null
                if(s == "" || s == null)
                {
                    return s;
                }*/

                if (string.IsNullOrEmpty(s))
                {
                    return s;
                }

                string majuscules = s.ToUpper();
                string minuscules = s.ToLower();

                //string resultat = majuscules[0] + minuscules.Substring(1); //Notation alternative tous caractères à partir de l'index
                string resultat = majuscules[0] + minuscules[1..];
                return resultat;
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
                                            new Pizza("ROYALE", 13f, false),
                                            new Pizza("margherita", 8f, true),
                                            new Pizza("calzone", 12f, false),
                                            new Pizza("complète", 9.5f, false)
                                        };
            foreach(var pizza in listePizzas)
            {
                pizza.Afficher();
            }
        }
    }
}
