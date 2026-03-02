using System;
using System.Collections.Generic;
using System.Text;
public static class GameUtils
{
    public static int Clamp(int value, int min, int max)
    {
        if (value < min)
        {
            return min;
        }
        else if (value > max)
        {
            return max;
        }

        return value;
    }

    public static int GetPercentage(int current, int max)
    {
        if (max == 0)
        {
            return 0;
        }

        return (current * 100) / max;
    }

    public static bool IsInRange(int value, int min, int max)
    {
        if (value >= min && value <= max)
        {
            return true; 
        }

        return false;
    }
}
