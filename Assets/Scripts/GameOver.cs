using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    
    public Canvas Gameplay;
    public Canvas Gameover;
    public Movement PHP;

	// Update is called once per frame
	void Update ()
    {
		if(PHP == null)
        {
            Gameplay.enabled = false;
            Gameover.enabled = true;
            
        }
	}
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Exitgame()
    {
        Application.Quit();
    }

}
