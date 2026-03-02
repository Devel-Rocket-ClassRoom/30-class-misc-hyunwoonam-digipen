using System;
using System.Collections.Generic;
using System.Text;

public class Money
{
    public int Gold { get; }
    public int Silver { get;}

    public Money(int gold, int silver)
    {
        this.Gold = gold;
        this.Silver = silver;   
    }

    public Money Add(int gold, int silver)
    {
        return new Money(Gold + gold, Silver + silver);
    }
    public Money Subtract(int gold, int silver)
    {
        int _gold = (Gold - gold);
        int _silver = (Silver - silver);

        if (_gold < 0)
        {
            _gold = 0;
        }
        if ( _silver < 0) 
        {
            _silver = 0;
        }

        return new Money(_gold, _silver);
    }

    public override string ToString()
    {
        return $"{Gold}골드 {Silver}실버";
    }
}

