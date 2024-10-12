using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject dialoguebox;
    public GameObject dialoguebox1;
    public GameObject dialoguebox2;

    public void OnTriggerEnter(Collider other)
    {
        dialoguebox.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        dialoguebox.SetActive(false);
    }

    public void Next()
    {
        dialoguebox2.SetActive(true);
        dialoguebox1.SetActive(false);
        dialoguebox2.SetActive(true);
    }
}
