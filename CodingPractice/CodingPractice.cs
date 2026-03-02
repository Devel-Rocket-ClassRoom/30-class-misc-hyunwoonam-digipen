using System;
using System.Collections.Generic;
using System.Text;

public partial class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public partial class Person
{
    public void Print()
    {
        Console.WriteLine($"{Name}: {Age}");
    }
}

public partial class Hello
{
    public void Hi()
    {
        Console.WriteLine("안녕하세요!");
    }
}

public partial class Hello
{
    public void Bye()
    {
        Console.WriteLine("안녕히 가세요!");
    }
}

public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

public static class StringHelper
{
    public static string CleanAndUpper(string input)
    {
        return input.Trim().ToUpper();
    }

    public static string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public static bool IsNullOrEmpty(string input)
    {
        return string.IsNullOrEmpty(input);
    }
}

public class MessageBuilder
{
    private string builder = "";

    public MessageBuilder AddText(string text)
    {
        builder += text;
        return this;
    }

    public MessageBuilder AddSpace()
    {
        builder += " ";
        return this;
    }

    public MessageBuilder AddNewLine()
    {
        builder += "\n";
        return this;
    }

    public string Build()
    {
        return builder;
    }
}

public class Point
{
    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point MoveBy(int dx, int dy)
    {
        return new Point(X + dx, Y + dy);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

public class MutableCircle
{
    public int Radius { get; set; }

    public MutableCircle(int r)
    {
        this.Radius = r;
    }
}

public class ImmutableCircle
{
    public int Radius { get; }

    public ImmutableCircle(int r)
    {
        this.Radius = r;
    }

    public ImmutableCircle WithRadius(int r)
    {
        return new ImmutableCircle(r);
    }
}

public class Player
{
    public readonly string Name;
    public readonly int Level;

    public Player(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public Player LevelUp()
    {
        return new Player(Name, Level + 1);
    }
}

public partial class Character
{
    private readonly string _name;
    private int _health;
    private int _level;

    public string Name => _name;
    public int Health => _health;
    public int Level => _level;

    public Character(string name)
    {
        _name = name;
        _health = 100;
        _level = 1;
    }
}

public partial class Character
{
    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health < 0)
        {
            _health = 0;
        }
        Console.WriteLine($"{_name}이(가) {damage}의 피해를 입음. 남은 체력: {_health}");
    }

    public void Heal(int amount)
    {
        _health += amount;
        Console.WriteLine($"{_name}이(가) {amount}만큼 회복함. 현재 체력: {_health}");
    }
}

public static class GameHelper
{
    public static int CalculateDamage(int baseDamage, int level)
    {
        return baseDamage + (level * 5);
    }

    public static bool IsAlive(int health)
    {
        return health > 0;
    }

    public static string GetHealthStatus(int health, int maxHealth)
    {
        if (maxHealth <= 0)
        {
            return health > 0 ? "오류" : "사망";
        }

        double ratio = (double)health / maxHealth;

        if (ratio >= 0.7)
        {
            return "양호";
        }
        else if (ratio >= 0.3)
        {
            return "주의";
        }
        else if (ratio > 0)
        {
            return "위험";
        }
        else
        {
            return "사망";
        }
    }
}

public class Vector2D
{
    public readonly double X;
    public readonly double Y;

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Vector2D Add(double x, double y)
    {
        return new Vector2D(X + x, Y + y);
    }

    public Vector2D Multiply(double scalar)
    {
        return new Vector2D(X * scalar, Y * scalar);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}