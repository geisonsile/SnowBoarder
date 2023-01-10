using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public TextMeshProUGUI txtCountDown;
    float timeRemaining = 3;
    bool isCount = false;

    
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        isCount = true;
    }

    
    void Update()
    {
        CountDown();
    }

    private void CountDown()
    {
        if (isCount)
        {
            if (timeRemaining > 1)
            {
                txtCountDown.text = timeRemaining.ToString();
                timeRemaining -= Time.deltaTime;
                
            }
            else
            {
                isCount = false;
                txtCountDown.text = "";
            }
        }
    }
}
