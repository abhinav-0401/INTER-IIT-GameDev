using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Health : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Player1, Player2;
    public float character_health_1 = 100f;
    public float character_health_2 = 100f;
    public static Character_Health instance;

    [SerializeField] TimeManager TM;
    public float slow_motion_health_damage = 0.1f;

    // public delegate void OnGameOver();
    // public static event OnGameOver onGameOver;
    public UI_Manager UIM;
    public bool GameHasEnded = false;
    private void Awake() {
        if(instance!=null){
            Destroy(gameObject);
        }
        else{
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if(character_health_1 <= 0f){
            // onGameOver();
            UIM.GameOver();
            Destroy(Player1);
            GameHasEnded = true;
            // Destroy(Player2);
        }
        if(character_health_2 <= 0f){
            // Destroy(Player1);
            // onGameOver();
            UIM.GameOver();
            Destroy(Player2);
            GameHasEnded = true;
        }

        Slow_Motion_Health_Down();
    }

    void Slow_Motion_Health_Down(){
        float slowMotionTime = TM.slowDownLength;
        if(Time.timeScale < 1 && TM.gamePaused == false){
            // Debug.Log(Time.timeScale);
            character_health_1 -= slow_motion_health_damage;
            character_health_2 -= slow_motion_health_damage;
        }
    }

}
