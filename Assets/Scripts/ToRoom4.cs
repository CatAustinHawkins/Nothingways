using UnityEngine;
using UnityEngine.SceneManagement;

public class ToRoom4 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Room4");
    }
}
