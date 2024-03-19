public class Colis
{
    public int Id { get; private set; }
    public float Poid { get; private set; }
    public string Taille { get; private set; }
    public bool IsFragile { get; private set; }

    public Colis(int id, float poid, string taille, bool isFragile)
    {
        Id = id;
        Poid = poid;
        Taille = taille;
        IsFragile = isFragile;
    }
}
