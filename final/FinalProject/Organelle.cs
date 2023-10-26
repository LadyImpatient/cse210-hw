using System;

abstract class Organelle
{
    public string Name { get; protected set; }
    public string Function { get; protected set; }

    public Organelle(string name, string function)
    {
        Name = name;
        Function = function;
    }

    public abstract string GetInfo(); // Abstraction
    public string GetName()
    {
        return Name;
    }

    public string GetFunction()
    {
        return Function;
    }
}
