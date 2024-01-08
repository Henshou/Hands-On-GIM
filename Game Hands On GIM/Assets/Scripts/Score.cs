using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text ScoreText;
    private int ScorePoint;
    
    void Start()
    {
        ScorePoint = 0;
        ScoreText.text = "Score :" + ScorePoint;
    }

    private void OnTriggerEnter2D(Collider2D Fishes)
    {
        if(Fishes.tag == "Fish")
        {
            ScorePoint += 1;
            Destroy(Fishes.gameObject);
            ScoreText.text = "Score : " + ScorePoint;
        }
    }
}
