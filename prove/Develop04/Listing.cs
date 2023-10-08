using System;

class ListingActivity : Activity
{
    public ListingActivity(string name) : base(name) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Description: This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }
}