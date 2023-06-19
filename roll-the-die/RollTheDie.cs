using System;

public class Player
{
    private Random _random = new Random();
    private readonly int _dieSize = 18;
    private readonly double _maxStrength = 100;

    public int RollDie() => _random.Next(1, _dieSize + 1);

    public double GenerateSpellStrength() => _random.NextDouble() * _maxStrength;
}
