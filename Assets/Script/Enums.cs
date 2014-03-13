using UnityEngine;
using System.Collections;

public static class Species {
    public const int Human = 0;
    public const int Elf = 1;
    public const int Oak = 2;
    public const int Naga = 3;
    public const int Insect = 4;
    public const int Undead = 5;
    public const int Dwarf = 6;
}

public static class Types {
    public const int Warrior = 0;
    public const int Magician = 1;
    public const int WarriorAndMagician=2;
    public const int Sctructure=3;
}

public static class CardTypes {
    public const int PlayerCard = 0;
    public const int SoldierCard = 1;
    public const int SpellCard = 2;
    public const int WeaponCard = 3;
    public const int StrategyCard = 4;
}

public static class RangeTypes {
    public const int All = 0;
    public const int _1 = 1;
    public const int _2 = 2;
    public const int _3 = 3;
    public const int _4 = 4;
    public const int _5 = 5;
    public const int _3x3 = 6;
    public const int _5x5 = 7;
    public const int _7x7 = 8;
    public const int _9x9 = 9;
    public const int _11x11 = 10;
}

public static class ValueModifier {

    public const int Set = 0;
    public const int Add = 1;
    public const int Subtract = 2;

}

public static class Operator {
    public const int Equal = 0;
    public const int SmallerThan = 1;
    public const int BiggerThan = 2;
    public const int EqualOrSmallerThan = 3;
    public const int EqualOrBiggerThan = 4;

}
public static class AttackTypes {
    public const int Physical = 0;
    public const int Magical = 1;
    public const int Absolute = 2;

}


public static class ConditionTiming {
    public const int PeriodBegin = 0;
    public const int Attack = 1;
    public const int Effect = 2;
    public const int Die = 3;
    public const int EffectUse = 4;
    public const int Summon = 5;
    public const int Revive = 6;
    public const int Move = 7;

}