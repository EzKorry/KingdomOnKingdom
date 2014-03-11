using UnityEngine;
using System.Collections;

public class CardSupporter : Card {

    public int pointConsumption;
    public int spellConsumption;
    public int duration;
    public int typeAvailable;
    public int speciesAvailable;


    protected CardSupporter() : base() {
        pointConsumption = 0;
        spellConsumption = 0;
        duration = 0;
        typeAvailable = 0;
        speciesAvailable = 0;
    
    }
}
