using UnityEngine;

public class moridialogue : MonoBehaviour
{
    public GameObject dialoguebox;
    public GameObject tip1;

    public void OnTriggerEnter(Collider other)
    {
        dialoguebox.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        dialoguebox.SetActive(false);
        tip1.SetActive(true);
    }
}
