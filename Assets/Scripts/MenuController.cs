using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
