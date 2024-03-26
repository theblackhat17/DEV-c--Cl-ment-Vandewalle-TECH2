using System;
using System.Collections.Generic;

public class Car
{
    public string Modele { get; private set; }
    public string Marque { get; private set; }
    public int Annee { get; private set; }
    public Colors Couleur { get; set; }
    private Queue<Tache> checklist = new Queue<Tache>();
    private List<string> reponsesNon = new List<string>(); 

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
            }
            else
            {
                reponsesNon.Add(currentTask.Nom); 
            }
        }

        if (reponsesNon.Count > 0)
        {
            Console.WriteLine("Récapitulatif des tâches pour lesquelles la réponse était 'non' avant la validation finale :");
            foreach (string tache in reponsesNon)
            {
                Console.WriteLine($"- {tache}");
            }
            Console.WriteLine("Toutefois, toutes les tâches ont finalement été validées.");
        }
        
        Console.WriteLine("Vroum Vroum, la voiture démarre !");
    }

    public void StartEngine()
    {
        Console.WriteLine("Le moteur démarre : Vroum Vroum!");
    }
}
