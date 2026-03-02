using System;
using System.Collections.Generic;
using System.Text;

public partial class Recipe
{
    public string Name { get; }
    public int Servings { get; }

    private string[] Material;
    private int Count;

    public Recipe(string name, int servings, int maxMaterial)
    {
        Name = name;
        Servings = servings;
        Material = new string[maxMaterial];
        Count = 0;
    }
}
