using UnityEngine;
using UnityEngine.SceneManagement;  //引用場景管理API

public class GameManager : MonoBehaviour
{
   public void RestartGame()
    {
        SceneManager.LoadScene("garbage");

    }

    public void QuitGame()
    {
        Application.Quit();

    }

}
