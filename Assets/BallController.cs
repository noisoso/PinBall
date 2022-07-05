using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    private GameObject scoreText;
    private   int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");
        
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.GetComponent<Text>().text = "Score "+ score;


        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
        
    }

    void OnCollisionEnter(Collision Scoreplus)
    {
        if (Scoreplus.gameObject.tag == "SmallStarTag")
        {
            score += 3;
        }
        else if (Scoreplus.gameObject.tag == "LargeStarTag")
        {
            score += 10;
        }
        else if (Scoreplus.gameObject.tag == "SmallCloudTag")
        {
            score += 5;
        }
        else if (Scoreplus.gameObject.tag == "LargeCloudTag")
        {
            score += 20;
        }
    }

}
