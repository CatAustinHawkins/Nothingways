using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleComplete : MonoBehaviour
{

    public GameObject surprise;
    public GameObject door1;
    public GameObject door2;


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
        door1.SetActive(false);
        door2.SetActive(true);
    
    }

}
