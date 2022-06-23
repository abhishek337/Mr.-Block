using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level2Player : MonoBehaviour
{
    public Rigidbody2D RB;

    public float speed;

    public GameObject gameWinScreen;

    private bool isGameOver = false;

    public GameObject Enemy1;
    public GameObject Enemy2;

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == true)
        {
            return;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            RB.velocity = new Vector2(speed, 0f);
        }
        else if (Input.GetAxis("Vertical") > 0)
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
            Debug.Log("Level 2 Completed!");
            gameWinScreen.SetActive(true);
            isGameOver = true;

            PlayerPrefs.SetInt("LevelTwo", 2);

            if (isGameOver == true)
            {
                Destroy(Enemy1);
                Destroy(Enemy2);
            }
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene("Level2");
        Debug.Log("Replay");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

    public void NextLevelthree()
    {
        SceneManager.LoadScene("LevelSelect");
        Debug.Log("Next Level");
    }
}
