using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey("Escape"))
        {
            Application.Quit();
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Room1");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
}
