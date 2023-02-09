using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMo_Trigger : MonoBehaviour
{
    [SerializeField] TimeManager timeManager;
    private void Update() {
        if(Input.GetKeyDown(KeyCode.R)){
            timeManager.DoSlowMo();
        }
    }
}
