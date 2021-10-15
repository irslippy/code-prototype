using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTImer : MonoBehaviour
{
    float currentTime = 0f;
    readonly float startingTime = 60f;

    [SerializeField] Text countdownText;

    

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 60f;

        if (Input.GetMouseButton(0))

            currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        
    }

    // Update is called once per frame
    void Update()
    {
          
        if(currentTime <= 10)
        {

            countdownText.color = Color.red;
        }

        if(currentTime <= 0)
        {
            Application.Quit();
            currentTime = 0;
        }
             
    }
}
