using System;
using System.Collections.Generic;
using System.Text;

public partial class Recipe
{
    public void AddIngredient(string ingredient)
    {
        if (Count < Material.Length)
        {
            Material[Count] = ingredient;
            Count++;
        }
        else
        {
            Console.WriteLine($"재료를 더 이상 추가할 수 없습니다.");
        }
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"=== {Name} ({Servings}인분) ===");
        Console.WriteLine("재료:");

        for (int i = 0; i < Count; i++)
        {
            Console.WriteLine($" {i + 1}. {Material[i]}");
        }
    }

    public bool HasIngredient(string ingredient)
    {
        for (int i = 0; i < Count; i++)
        {
            if (Material[i] == ingredient)
            {
                return true;
            }
        }

        return false;
    }
}