using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class CardUnit : Card {

    public int health;
    public int healthRegen;
    public int mana;
    public int manaRegen;
    public int attack;
    public int defense;
    public int spell;
    public int type;
    public int species;
    public int mobility;
    public int range;

    protected CardUnit()
        : base() {
        this.health = 0;
        this.healthRegen = 0;
        this.mana = 0;
        this.manaRegen = 0;
        this.attack = 0;
        this.defense = 0;
        this.spell = 0;
        this.type = 0;
        this.species = 0;
        this.mobility = 0;
        this.range = 0;
    }



}

