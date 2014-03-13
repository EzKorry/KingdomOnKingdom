using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Ability  {


    public int timing;
    
    

    public Ability() {

        this.timing = ConditionTiming.EffectUse;
        
    }

    public virtual bool isConditionAccepted() {
        return false;
    }


    

    
	
}
