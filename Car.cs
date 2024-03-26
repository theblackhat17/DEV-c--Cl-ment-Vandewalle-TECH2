using System;
using System.Collections.Generic;

public class Car
{
    public string Modele { get; private set; }
    public string Marque { get; private set; }
    public int Annee { get; private set; }
    public Colors Couleur { get; set; }

    private Queue<Tache> checklist = new Queue<Tache>();

    public string NomComplet => $"{Marque} {Modele}";

    public Car(string modele, string marque, int annee, Colors couleur)
    {
        Modele = modele;
        Marque = marque;
        Annee = annee;
        Couleur = couleur;

        checklist.Enqueue(new Tache("Permis sur soi"));
        checklist.Enqueue(new Tache("Essence remplie"));
        checklist.Enqueue(new Tache("Ceinture mise"));
    }
    public void AskForChecklist()
    {
        Console.WriteLine("Veuillez compléter la checklist :");
        while (checklist.Count > 0)
        {
            Tache currentTask = checklist.Peek(); 
            Console.WriteLine($"Avez-vous {currentTask.Nom}? (oui/non)");

            string reponse = Console.ReadLine().Trim().ToLower();
            if (reponse == "oui")
            {
                checklist.Dequeue(); 
                currentTask.IsDone = true;
            }
        }

        Console.WriteLine("Vroum Vroum, la voiture démarre !");
    }

    public void StartEngine()
    {
        if (checklist.Count == 0)
        {
            Console.WriteLine("Le moteur démarre : Vroum Vroum!");
        }
        else
        {
            Console.WriteLine("La checklist n'est pas complète. La voiture ne peut pas démarrer.");
        }
    }
}
