using System;

abstract class Character
{
    private string _characterType;
    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {_characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
//        if (target.Vulnerable())
//        {
//            return 10;
//        }
//        else
//        {
//            return 6;
//        }
        return (target.Vulnerable() ? 10 : 6);
    }
}

class Wizard : Character
{
    bool _spellPrepared;
    public Wizard() : base("Wizard")
    {
        _spellPrepared = false;
    }

    public override int DamagePoints(Character target)
    {
        return _spellPrepared ? 12 : 3;
    }

    public void PrepareSpell()
    {
        _spellPrepared= true;
    }
    public override bool Vulnerable()
    {
        return _spellPrepared ? false : true; 
    }
}
