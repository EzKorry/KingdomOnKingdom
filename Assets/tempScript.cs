using UnityEngine;
using System.Collections;

public class tempScript : MonoBehaviour {
    void Start() {
        Golem g = new Golem();
        int a;
        a= g.mana;
        Debug.Log(a);
        Debug.Log(g.mana);
        Debug.Log(g.abilityList);



        CardManager b = new CardManager(g);
    }
   

}

    

