using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D RB;

    public float speed;

    public GameObject gameWinScreen;

    public GameObject gamePauseScreen;

    private bool isGameOver = false;

    // Update is called once per frame
    void Update()
    {
    
    if(isGameOver == true)
        {
            return;
        }

       if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Paused!");
            gamePauseScreen.SetActive(true);
            isGameOver = true;
        }

     if(Input.GetAxis("Horizontal") > 0)
        {
            RB.velocity = new Vector2(speed, 0f);
        }   
     else if(Input.GetAxis("Vertical") > 0)
        {
            RB.velocity = new Vector2(0f, speed);
        }
     else if (Input.GetAxis("Horizontal") < 0)
        {
            RB.velocity = new Vector2(-speed, 0f);
        }
     else if (Input.GetAxis("Vertical") < 0)
        {
            RB.velocity = new Vector2(0f, -speed);
        }
     else if ((Input.GetAxis("Vertical") == 0) && (Input.GetAxis("Horizontal") == 0))
        {
            RB.velocity = new Vector2(0f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door")
        {
            Debug.Log("Level 1 Completed!");
            gameWinScreen.SetActive(true);
            isGameOver = true;

            PlayerPrefs.SetInt("LevelOne",1);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Replay");
    }

    public void ResumeLevel()
    {
        gamePauseScreen.SetActive(false);
        isGameOver = false;
        Debug.Log("Resume");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("LevelSelect");
        Debug.Log("Next Level");
    }
}