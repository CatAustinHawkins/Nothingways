using UnityEngine;

public class DIalogue_Avis : MonoBehaviour
{
    public GameObject dialoguebox;

    public void OnTriggerEnter(Collider other)
    {
        dialoguebox.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        dialoguebox.SetActive(false);
    }
}
