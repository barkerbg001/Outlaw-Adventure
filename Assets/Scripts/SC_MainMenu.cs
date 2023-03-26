using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject HelpMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSelect");
    }

    public void HelpButton()
    {
        // Show Help Menu
        MainMenu.SetActive(false);
        HelpMenu.SetActive(true);
    }

    public void MainMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(true);
        HelpMenu.SetActive(false);
    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}