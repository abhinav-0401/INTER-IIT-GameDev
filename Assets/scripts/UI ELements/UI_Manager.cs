using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject PauseButton;
    [SerializeField] GameObject GameOverScreen;
    [SerializeField] TimeManager TM;
    // private void Start() {
    //     Character_Health.onGameOver += GameOver;
    // }
    public void Pause()
    {
        Time.timeScale = 0f;
        PauseButton.SetActive(true);
        TM.gamePaused = true;
    }
    public void UnPause()
    {
        Time.timeScale = 1f;
        TM.gamePaused = false;
        PauseButton.SetActive(false);
    }
    public void GoToMainMenu(){
        Debug.Log("Main Menu button activated");
        SceneManager.LoadScene("Main Menu");
    }
    public void PlayGame(){
        SceneManager.LoadScene("Play Scene");
    }
    public void Quit(){
        Debug.Log("App is closed");
        Application.Quit();
    }
    public void LeaderBoard(){
        Debug.Log("LeaderBoard is displayed");
        SceneManager.LoadScene("leaderBoard");
    }
    public void GameOver(){
        if(GameOverScreen){
            GameOverScreen.SetActive(true);
        }
    }
    
}


