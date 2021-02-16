using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public void Save()
    {
        PlayerPrefs.SetInt("Level4", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.Save();
        Debug.Log("SavedLevel: "+PlayerPrefs.GetInt("Level4"));
    }

    public void Load()
    {
        if(PlayerPrefs.GetInt("Level4") > 0)
        {
            if(PlayerPrefs.GetInt("Level4") < SceneManager.GetActiveScene().buildIndex)
            {

            }
            else if(PlayerPrefs.GetInt("Level4") == SceneManager.GetActiveScene().buildIndex)
            {
                
            }
            else
            {
                SceneManager.LoadScene(PlayerPrefs.GetInt("Level4"));
            }
        }
    }

    void Start()
    {
        Load();
    }

    void Update()
    {
        Save();
    }
}
