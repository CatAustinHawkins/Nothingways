using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
