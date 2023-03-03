using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberTransfer : MonoBehaviour
{

    public string code;
    public GameObject inputField;
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
        if(code == "1987")
        {
            surprise.SetActive(true);
            door1.SetActive(false);
            door2.SetActive(true);
        }
    }

    public void StoreCode()
    {
        code = inputField.GetComponent<Text>().text;
    }
}
