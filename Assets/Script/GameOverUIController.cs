using System.Collections;
using System.Collections.Generic;
// using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    public Button mainMenuButton;


    private void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenuButton);
    }

    private void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
