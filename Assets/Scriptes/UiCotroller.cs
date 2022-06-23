using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiCotroller : MonoBehaviour
{
    public GameObject lock1;
    public Button level2;
    public GameObject lock2;
    public Button level3;

    // Update is called once per frame
    void Update()
    {
        unlockLevelTwo();
        unlockLevelThree();
    }

    public void unlockLevelTwo()
    {
        if (PlayerPrefs.GetInt("LevelOne") == 1)
        {
            lock1.SetActive(false);
            level2.interactable = true;
        }

    }

    public void unlockLevelThree()
    {
        if (PlayerPrefs.GetInt("LevelTwo") == 2)
        {
            lock2.SetActive(false);
            level3.interactable = true;
        }

    }
}
