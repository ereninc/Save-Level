using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoadSystem : MonoBehaviour
{
    public void Save()
    {
        PlayerPrefs.SetInt("Level", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.Save();
        Debug.Log("SavedLevel: "+PlayerPrefs.GetInt("Level"));
    }

    public void Load()
    {
        if(PlayerPrefs.GetInt("Level") > 0)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
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
