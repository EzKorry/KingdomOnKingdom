using UnityEngine;
using UnityEditor;
using System.Collections;

public class testMain : MonoBehaviour {
    void Start() {

        CardManager a = new CardManager(new Golem(), new Coordinate(1, 2));

        a.damage(1, AttackTypes.Magical);
       
        


    }
   

}

    

