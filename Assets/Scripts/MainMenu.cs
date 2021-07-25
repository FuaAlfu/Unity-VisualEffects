using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int levelIndex = 1;

    public void Play()
    {
        Invoke(nameof(LoadLevel), 1.5f);
    }

    private void LoadLevel()
    {
        SceneManager.LoadScene(levelIndex);
    }
}
