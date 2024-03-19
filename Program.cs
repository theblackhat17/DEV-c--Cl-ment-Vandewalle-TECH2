using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        Car c3 = new Car("c3", "citroen", 2015, Colors.Rouge);
        Console.WriteLine($" Nom complet de ma voiture : {c3.NomComplet} Année de fabrication : {c3.Annee}");
        c3.StartEngine();

        Camion ada = new Camion("ada", "merk", 2012, Colors.Noir, 1000);
        Console.WriteLine($" Nom complet de mon camion : {ada.NomComplet} Année de fabrication : {ada.Annee}");

        Colis colis1 = new Colis(1, 200, "Moyen", false);
        Colis colis2 = new Colis(2, 300, "Grand", true);
        Colis colis3 = new Colis(3, 500, "Très Grand", false);

        List<Colis> colisAAjouter = new List<Colis> { colis1, colis2, colis3 };

        bool ajoutReussi = ada.TryAddColis(colisAAjouter);

        if (ajoutReussi)
        {
            Console.WriteLine("Tous les colis ont été ajoutés avec succès au camion.");
        }
        else
        {
            Console.WriteLine("L'ajout des colis a dépassé la limite de poids du camion. Certains colis n'ont pas été ajoutés.");
        }
    }
}
