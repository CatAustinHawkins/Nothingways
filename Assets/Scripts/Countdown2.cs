using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Countdown2 : MonoBehaviour
{
    public float currentTime = 180f;

    public Text countdown;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 180f;
    }

    // Update is called once per frame
    void Update()
    {

        if (currentTime <= 0.01f)
        {
            SceneManager.LoadScene("Room3Death");
        }

        currentTime -= 1 * Time.deltaTime;
        countdown.text = currentTime.ToString("0");

        Mathf.Clamp(currentTime, 0f, 180f);


    }
}
