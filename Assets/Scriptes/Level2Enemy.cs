using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level2Enemy : MonoBehaviour
{
    public GameObject gameLostPanel;

    public GameObject player;

    private void OnCollisionEnter2D(Collision2D collide)
    {
        if (collide.gameObject.tag == "Enemy")
        {
            Debug.Log("Level Failed!");
            gameLostPanel.SetActive(true);
            Destroy(player);
        }
    }

    public void ReplayLeveltwo()
    {
        SceneManager.LoadScene("Level2");
        Debug.Log("Replay");
    }
}
