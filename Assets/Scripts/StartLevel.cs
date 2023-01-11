using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    private float timeRemaining = 3;
    private bool isCount = false;

    public TextMeshProUGUI txtCountDown;
    public PlayerController playerController;

    
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.2f);
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
                txtCountDown.text = Mathf.Round(timeRemaining).ToString();
                timeRemaining -= Time.deltaTime;
                
            }
            else
            {
                LevelStart();
            }
        }
    }

    private void LevelStart()
    {
        isCount = false;
        txtCountDown.text = "";
        playerController.rb2d.bodyType = RigidbodyType2D.Dynamic;
    }
}
