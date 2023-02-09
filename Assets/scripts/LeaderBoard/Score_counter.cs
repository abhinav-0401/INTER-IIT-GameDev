using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_counter : MonoBehaviour
{
    // Start is called before the first frame update4
    public static Score_counter instance;
    public TextMeshProUGUI ScoreText;
    public float score = 0f;
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
        if(!Character_Health.instance.GameHasEnded){
            ScoreCounting();
        }
        // ScoreCounting();
        
        // time based score counting
        if(!ScoreText){
            return;
        }
        ScoreText.text = "Score: "+((int)score).ToString();
    }
    void ScoreCounting(){
        score+=Time.unscaledDeltaTime;
    }
    // void OnGameOver_Score_Display(){
        
    // }
    
}
