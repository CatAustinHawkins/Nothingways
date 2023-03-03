using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moridialogue : MonoBehaviour
{
    public GameObject dialoguebox;
    public GameObject tip1;

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
        tip1.SetActive(true);
    }
}
