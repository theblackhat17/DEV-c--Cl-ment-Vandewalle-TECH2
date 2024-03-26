using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Camion : Car
{

    private Stack<Colis> colisDansLeCamion = new Stack<Colis>();
    public float LimitePoids { get; private set; }

    public Camion(string modele, string marque, int annee, Colors couleur, float limitePoids) : base(modele, marque, annee, couleur)
    {
        LimitePoids = limitePoids;
    }


    public bool TryAddColis(Colis colis)
    {
        if (PoidsActuel() + colis.Poid > LimitePoids)
        {
            return false; 
        }
        else
        {
            colisDansLeCamion.Push(colis); 
            return true; 
        }
    }

  
    public float PoidsActuel()
    {
        float total = 0;
        foreach (var colis in colisDansLeCamion)
        {
            total += colis.Poid;
        }
        return total;
    }


    public Colis RetirerDernierColis()
    {
        if (colisDansLeCamion.Count > 0)
        {
            return colisDansLeCamion.Pop(); 
        }
        else
        {
            throw new InvalidOperationException("Il n'y a pas de colis dans le camion.");
        }
    }
}


// public void AfficherOrdreDeVidage()
// {
//     foreach (var colis in ColisList)
//     {
//         Console.WriterLine($"Colis ID: {colis.Id}");
//     }
// }




// Avoir une check list à valider avnat de démarrer la voiture | Utiliser absoluement des queue 
// Mettre en place un système en initilaisant la check list dans le constructeur si elle ne va pas bouger mais si elle va bouger je ne la met pas dedans pour avoir des méthodes