using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Golem : CardSoldier {

    






    public Golem()
        : base() {

           
        abilityList.Add(new Golem_PowerUP());


        cardID = 1;

        cardName = "골렘";
        description = "골렘은 짱짱쎄다.";
        health = 40;
        healthRegen = 2;
        mana = 70;
        manaRegen = 10;
        attack = 10;
        defense = 6;
        spell = 5;
        type = Types.Warrior;
        species = Species.Dwarf;
        mobility = 1;
        range = 1;
        leadershipConsumption = 3;
        pointConsumption = 50;
        
    }

    


}
