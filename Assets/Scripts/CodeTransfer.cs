using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CodeTransfer : MonoBehaviour
{

    public string code;
    public GameObject inputField;
    public GameObject surprise;
    public GameObject door;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (code == "1987")
        {
            surprise.SetActive(true);
            door.GetComponent<ToGameEnd>().puzzle2();
        }
    }

    public void StoreCode()
    {
        code = inputField.GetComponent<Text>().text;
    }
}
