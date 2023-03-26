using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void LevelSelect()
    {
        // Play Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSelect");
    }

    public void Level1()
    {
        // Level 1 Button has been pressed, load Level 1 Scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        // Level 2 Button has been pressed, load Level 2 Scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        // Level 3 Button has been pressed, load Level 3 Scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3");
    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}