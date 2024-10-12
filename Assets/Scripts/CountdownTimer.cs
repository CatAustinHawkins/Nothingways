using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float currentTime = 120f;

    public Text countdown;

    void Start()
    {
        currentTime = 120f;
    }

    void Update()
    {
        if (currentTime <= 0.01f)
        {
            SceneManager.LoadScene("Room3Death");
        }

        currentTime -= 1 * Time.deltaTime;
        countdown.text = currentTime.ToString("0");

        Mathf.Clamp(currentTime, 0f, 120f);
    }
}
