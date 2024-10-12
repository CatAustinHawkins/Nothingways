using UnityEngine;

public class Tips : MonoBehaviour
{
    public GameObject tips;

    public void TipOpen()
    {
        tips.SetActive(true);
    }

    public void TipClosed()
    {
        tips.SetActive(false);
    }
}
