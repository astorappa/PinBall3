using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ConScore : MonoBehaviour
{
    public Text ScoreText; 
    private int totalScore = 0;  
    public int smallStarPoints = 5;
    public int largeStarPoints = 20;
    public int smallCloudPoints = 30;
    public int largeCloudPoints = 50;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SmallStarTag"))
        {
            totalScore += smallStarPoints;
        }
        else if (collision.gameObject.CompareTag("LargeStarTag"))
        {
            totalScore += largeStarPoints;
        }
        else if (collision.gameObject.CompareTag("SmallCloudTag"))
        {
            totalScore += smallCloudPoints;
        }
        else if (collision.gameObject.CompareTag("LargeCloudTag"))
        {
            totalScore += largeCloudPoints;
        }

        UpdateScoreText(); 
    }
    private void UpdateScoreText()
    {
        ScoreText.text = "Score: " + totalScore;
    }
}
