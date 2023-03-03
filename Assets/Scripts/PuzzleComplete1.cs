using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleComplete1 : MonoBehaviour
{

    public GameObject door;

    public GameObject surprise;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        surprise.SetActive(true);
        door.GetComponent<ToGameEnd>().puzzle1();

    }
}
