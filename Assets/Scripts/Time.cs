using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Text timerText; 
    private float startTime;

    private void Start()
    {
        startTime = Time.time; 
    }

    private void Update()
    {
        float timeElapsed = Time.time - startTime;
        string formattedTime = FormatTime(timeElapsed);
        timerText.text = formattedTime;
    }

    private string FormatTime(float time)
    {
        int minutes = (int)time / 60;
        int seconds = (int)time % 60;
        int milliseconds = (int)(time * 100) % 100;

        return string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }
}
