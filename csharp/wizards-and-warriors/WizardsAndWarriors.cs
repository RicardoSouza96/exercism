using System;

abstract class Character
{
    private string _charType;
    protected Character(string characterType) => _charType = characterType;

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {_charType}";
}

class Warrior : Character
{
    public Warrior() : base(characterType: "Warrior") {}

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    private bool _spellIsPrepared = false;
    public Wizard() : base(characterType: "Wizard")
    {}

    public override int DamagePoints(Character target) => _spellIsPrepared ? 12 : 3;

    public void PrepareSpell() => _spellIsPrepared = true;

    public override bool Vulnerable() => !_spellIsPrepared;
}