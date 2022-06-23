using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelection : MonoBehaviour
{
    public void openLevel()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Level 1");
    }

    public void openLevelTwo()
    {
            SceneManager.LoadScene("Level2");
            Debug.Log("Level 2");      
    }

    public void openLevelThree()
    {
        SceneManager.LoadScene("Level3");
        Debug.Log("Level 3");
    }
}
