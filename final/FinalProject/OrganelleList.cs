using System;

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
            Console.WriteLine("\n Custom organelle limit reached.");
        }
    }

    public Organelle[] GetOrganelles()
    {
        Organelle[] organelles = new Organelle[customOrganelleCount];
        Array.Copy(customOrganelles, organelles, customOrganelleCount);
        return organelles;
    }

    public string[] GetOrganelleInfo()
    {
        string[] organelleInfo = new string[customOrganelleCount];
        for (int i = 0; i < customOrganelleCount; i++)
        {
            organelleInfo[i] = $"{customOrganelles[i].Name} - {customOrganelles[i].Function}";
        }
        return organelleInfo;
    }

    public Organelle GetOrganelleByName(string name)
    {
        foreach (Organelle organelle in customOrganelles)
        {
            if (organelle.Name == name)
            {
                return organelle;
            }
        }
        return null;
    }
}
