using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameEnd : MonoBehaviour
{
    public bool puzzle1complete = false;

    public bool puzzle2complete = false;

    public void puzzle1()
    {
        puzzle1complete = true;
    }

    public void puzzle2()
    {
        puzzle2complete = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(puzzle1complete == true && puzzle2complete == true)
        {
            SceneManager.LoadScene("GameEnd");
        }
    }
}
