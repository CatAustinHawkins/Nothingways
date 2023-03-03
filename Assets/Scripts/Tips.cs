using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tips : MonoBehaviour
{

    public GameObject tips;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TipOpen()
    {
        tips.SetActive(true);
    }

    public void TipClosed()
    {
        tips.SetActive(false);
    }

}
