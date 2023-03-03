using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dialogue : MonoBehaviour
{
    public GameObject dialoguebox;
    public GameObject dialoguebox1;
    public GameObject dialoguebox2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
