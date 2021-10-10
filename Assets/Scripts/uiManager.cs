using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    public Button[] buttons;
    public Text scoreText;
    int score;
    bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver=false;
        score=0;
        InvokeRepeating("scoreUpdate",1.0f,0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text= "SCORE: "+score;
    }

    void scoreUpdate(){
        if(gameOver==false){
        score +=1;}
    }

    public void gameOverActivated(){
        gameOver=true;
        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }
    public void pause(){
        if(Time.timeScale == 1)
        {
            Time.timeScale=0;
        }
        else if(Time.timeScale==0)
        {
            Time.timeScale=1;
        }
    }
    public void playbutton()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void menubutton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void quitbutton()
    {
        Application.Quit();
    }
    public void replaybutton(){
        Application.LoadLevel(Application.loadedLevel);
    }
    public void returntomenu(){
        SceneManager.LoadScene("menuScene");
    }
    public void endgame()
    {
        Application.Quit();
    }
}
