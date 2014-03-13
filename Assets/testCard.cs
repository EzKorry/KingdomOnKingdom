using UnityEngine;
using System.Collections;

public class testCard : MonoBehaviour {

    public Transform prefab;
    private Transform prefab2;
    void Start() {
        
          prefab2 = Instantiate(prefab) as Transform;
        
       
    }
}
