using UnityEngine;

public class PuzzleComplete : MonoBehaviour
{
    public GameObject surprise;
    public GameObject door1;
    public GameObject door2;

    private void OnTriggerEnter(Collider other)
    {
        surprise.SetActive(true);
        door1.SetActive(false);
        door2.SetActive(true);
    }
}
