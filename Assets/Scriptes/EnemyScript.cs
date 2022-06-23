using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject gameLostPanel;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.tag == "Enemy")
        {
            Debug.Log("Level Failed!");
            gameLostPanel.SetActive(true);
            Destroy(player);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Replay");
    }
}
