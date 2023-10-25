using System;

// OrganelleList class for keeping track of custom organelles
class OrganelleList
{
    private Organelle[] customOrganelles;
    private int customOrganelleCount;

    public OrganelleList()
    {
        customOrganelles = new Organelle[10];
        customOrganelleCount = 0;
    }

    public void AddOrganelle(CustomOrganelle organelle)
    {
        if (customOrganelleCount < customOrganelles.Length)
        {
            customOrganelles[customOrganelleCount] = organelle;
            customOrganelleCount++;
        }
        else
        {
            Console.WriteLine("Custom organelle limit reached.");
        }
    }

    public string GetOrganelleList()
    {
        string list = "Custom Organelles:\n";
        for (int i = 0; i < customOrganelleCount; i++)
        {
            list += customOrganelles[i].GetInfo() + "\n";
        }
        return list;
    }
}
