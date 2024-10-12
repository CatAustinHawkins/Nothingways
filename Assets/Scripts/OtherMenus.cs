using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherMenus : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("Escape"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void BacktoMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void restart3()
    {
        SceneManager.LoadScene("Room3");
    }

    public void restart4()
    {
        SceneManager.LoadScene("Room4");
    }
}
