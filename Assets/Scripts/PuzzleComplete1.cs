using UnityEngine;

public class PuzzleComplete1 : MonoBehaviour
{
    public GameObject door;

    public GameObject surprise;

    private void OnTriggerEnter(Collider other)
    {
        surprise.SetActive(true);
        door.GetComponent<ToGameEnd>().puzzle1();
    }
}
