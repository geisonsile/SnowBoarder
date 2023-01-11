using TMPro;
using UnityEngine;
public class Timer : MonoBehaviour
{
    private float time = 0;
    public bool timerIsRunning = false;
    [SerializeField] private TextMeshProUGUI timeText;


    private void Start()
    {
        
    }
    void Update()
    {
        if (timerIsRunning)
        {
            time += Time.deltaTime;
            DisplayTime(time);
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
