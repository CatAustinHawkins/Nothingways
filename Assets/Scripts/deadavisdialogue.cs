using UnityEngine;

public class deadavisdialogue : MonoBehaviour
{
    public GameObject dialoguebox;
    public GameObject tip2;

    public void OnTriggerEnter(Collider other)
    {
        dialoguebox.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        dialoguebox.SetActive(false);
        tip2.SetActive(true);
    }
}
