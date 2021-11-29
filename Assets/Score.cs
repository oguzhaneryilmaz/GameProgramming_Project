using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float highestScoreValue = 0;
    public static float scoreValue = 0;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text= "Highest Score = "+ highestScoreValue+ "\n" + "Score = " + scoreValue;
        scoreValue += Time.deltaTime/2;

    }
}
