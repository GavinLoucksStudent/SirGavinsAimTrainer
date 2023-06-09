
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timer;

    public float timeRemaining = 60;


    void Update()
    {
       if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimer();
        }
    }


    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void UpdateTimer()
    {
        timer.text = timeRemaining.ToString();
    }
}
