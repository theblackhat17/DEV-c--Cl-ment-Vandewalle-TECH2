public class Tache
{
    public bool IsDone { get; set; }
    public string Nom { get; private set; }

    public Tache(string nom)
    {
        Nom = nom;
        IsDone = false; 
    }
}