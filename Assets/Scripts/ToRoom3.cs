using UnityEngine;
using UnityEngine.SceneManagement;

public class ToRoom3 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Room3");
    }
}
