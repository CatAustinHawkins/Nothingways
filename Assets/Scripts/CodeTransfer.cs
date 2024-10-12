using UnityEngine;
using UnityEngine.UI;
public class CodeTransfer : MonoBehaviour
{
    public string code;
    public GameObject inputField;
    public GameObject surprise;
    public GameObject door;

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
