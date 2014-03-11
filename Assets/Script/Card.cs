using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Card  {

    public int cardID;
    public int cardType;
    public string cardName;
    public string description;
    public Texture2D cardTexture;
    public List<Ability> abilityList;



    protected Card() {
        this.cardID = 0;
        this.cardType = 0;
        this.cardName = "";
        this.description = "";
        this.cardTexture = new Texture2D(200,200);
        this.abilityList = new List<Ability>();
        ;
    }

    


    // Supporter Card
    
    


    
    
    






}
