using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class CardSoldier : CardUnit {

    public  int leadershipConsumption;
    public  int pointConsumption;

    protected CardSoldier()
        : base() {
        this.leadershipConsumption = 0;
        this.pointConsumption = 0;
    }

}
