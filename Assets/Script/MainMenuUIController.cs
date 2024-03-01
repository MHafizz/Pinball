using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditButton.onClick.AddListener(CreditButton);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    private void CreditButton()
    {
        SceneManager.LoadScene("Credit");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
