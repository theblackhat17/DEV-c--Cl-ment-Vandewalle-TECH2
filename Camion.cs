using System.Collections.Generic; 

public class Camion : Car
{
    private List<Colis> colisDansLeCamion = new List<Colis>();
    public float LimitePoids { get; private set; }

    public Camion(string modele, string marque, int annee, Colors couleur, float limitePoids) : base(modele, marque, annee, couleur)
    {
        LimitePoids = limitePoids;
    }

    public bool TryAddColis(List<Colis> nouveauxColis)
    {
        float poidsTotalNouveauxColis = 0;
        foreach (var colis in nouveauxColis)
        {
            poidsTotalNouveauxColis += colis.Poid;
        }

        if (PoidsActuel() + poidsTotalNouveauxColis > LimitePoids)
        {
            return false;
        }
        else
        {
            colisDansLeCamion.AddRange(nouveauxColis); 
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
}
