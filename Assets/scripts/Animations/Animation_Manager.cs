using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public static Animation_Manager instance;
    
    
    private void Awake() {
        if(instance!=null){
            Destroy(gameObject);
        }
        else{
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }
    
}
