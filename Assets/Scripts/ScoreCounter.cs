using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

    public Movement Hp;
    public Text healthText;
    public float Score;
    public Text ScoreText;
    public Text ScoreRead;

	// Use this for initialization
	void Start ()
    {
        Score = 0f;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        healthText.text = "Health: " + Hp.PHP.ToString();
        ScoreText.text = "Score: " + Score.ToString();
        ScoreRead.text = "Score: " + Score.ToString();
    }
}
