using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public void GoToGameScene()
    {
        Invoke("ActionGame", 0.5f);
    }
    void ActionGame() { SceneManager.LoadScene("GoVirus"); }

    public void GoToHowScene()
    {
        Invoke("ActionHowScene", 0.5f);
    }
    void ActionHowScene() { SceneManager.LoadScene("HowScene"); }

    public void QuitGame()
    {
        Invoke("ActionQuit", 0.5f);
    }
    void ActionQuit() { Application.Quit(); }

    public void Restart()
    {
        Invoke("ActionRestart", 0.5f);
    }
    void ActionRestart() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }

    public void GoToMainMenu()
    {
        Invoke("ActionMenu", 0.5f);

    }
    void ActionMenu() {SceneManager.LoadScene("MainMenu"); }

    public void GoToCredit()
    {
        Invoke("ActionCredit", 0.5f);
    }
    void ActionCredit() {SceneManager.LoadScene("Credit"); }
}
