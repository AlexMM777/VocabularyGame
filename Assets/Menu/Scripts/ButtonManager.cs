using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void NewGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }

    public void QuExitBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);

    }

    public void CancelBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);

    }

    public void SettingsBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);

    }

    public void LoadOthSceneBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }
}