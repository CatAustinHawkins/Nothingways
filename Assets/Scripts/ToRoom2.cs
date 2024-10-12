using UnityEngine;
using UnityEngine.SceneManagement;

public class ToRoom2 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Room2");
    }
}
