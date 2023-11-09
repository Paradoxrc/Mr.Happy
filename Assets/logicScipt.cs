using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScipt : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource Src;
    public AudioSource Src2;
    public AudioClip src1;
    public AudioClip src2;
    public AudioClip src3;
    private float timer0 = 41;
    
    

    [ContextMenu("Increase Score")]
public void addscore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
        Src.clip = src1;
        Src.Play();
        

    }
       
    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver() {
        gameOverScreen.SetActive(true);
        Src.clip = src2;
        Src.Play();

    }
    void Update()
    {
        if (timer0 < 40)
        {
            timer0 = timer0 + Time.deltaTime;
        }
        else {
            Src2.clip = src3;
            Src2.Play();
            timer0 = 0;
        }
    }

}
