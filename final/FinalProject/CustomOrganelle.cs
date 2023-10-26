using System;

// CustomOrganelle class for adding custom organelles
class CustomOrganelle : Organelle
{
    public CustomOrganelle(string name, string function) : base(name, function) { }

    public override string GetInfo()
    {
        return $"\n {Name}: {Function}";
    }
}
