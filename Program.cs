using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {

        Car c3 = new Car("c3", "citroen", 2015, Colors.Rouge);
        Console.WriteLine($"Nom complet de ma voiture : {c3.NomComplet}. Année de fabrication : {c3.Annee}.");


        c3.AskForChecklist(); 
        
   
        c3.StartEngine();


        Camion ada = new Camion("ada", "merk", 2012, Colors.Noir, 1000);
        Console.WriteLine($"Nom complet de mon camion : {ada.NomComplet}. Année de fabrication : {ada.Annee}.");


        List<Colis> colisAAjouter = new List<Colis>
        {
            new Colis(1, 200, "Moyen", false),
            new Colis(2, 300, "Grand", true),
            new Colis(3, 500, "Très Grand", false)
        };


        foreach (Colis colis in colisAAjouter)
        {
            bool ajoutReussi = ada.TryAddColis(colis);
            if (ajoutReussi)
            {
                Console.WriteLine($"Le colis {colis.Id} a été ajouté avec succès.");
            }
            else
            {
                Console.WriteLine($"L'ajout du colis {colis.Id} a dépassé la limite de poids du camion.");

            }
        }
    }
}
