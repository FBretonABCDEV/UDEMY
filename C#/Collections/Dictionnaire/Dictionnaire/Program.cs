using System;

namespace Dictionnaire
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Dictionary
            //Clef -> valeur
            //nom numéro
            var dictionnaire = new Dictionary<string, string>();

            //Méthode 1 pour ajouter valeur
            dictionnaire.Add("Jean", "+33628153467");
            dictionnaire.Add("Henry", "+33652439481");

            //Méthode 2 pour ajouter valeur
            dictionnaire["Marie"] = "+33665483518";
            Console.WriteLine(dictionnaire["Marie"]);
        }
    }
}
