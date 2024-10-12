using UnityEngine;
using UnityEngine.UI;

public class NumberTransfer : MonoBehaviour
{
    public string code;
    public GameObject inputField;
    public GameObject surprise;
    public GameObject door1;
    public GameObject door2;

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
