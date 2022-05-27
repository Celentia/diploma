using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveController : MonoBehaviour
{
    void Start()
    {
        string activeScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LevelSaved", activeScene);
    }
}
