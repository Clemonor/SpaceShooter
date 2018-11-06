using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject[] enemyVer;

    float cooldownTimer;

    public ScoreCounter Point;

    void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (cooldownTimer == 0)
            SpawnEnemy();

        Cooldown();
    }

    void Cooldown()
    {

        if (cooldownTimer > 0 && cooldownTimer < 2)
            cooldownTimer += Time.deltaTime;
        else if (cooldownTimer >= 2)
            cooldownTimer = 0;
    }

    void SpawnEnemy()
    {
        int selectedEnemyType = Random.Range(0, MaxVerNumber());

        Vector2 spawnPosition = new Vector2(transform.position.x, Random.Range(-3, 3));

        GameObject createdEnemy = Instantiate(enemyVer[selectedEnemyType]);
        createdEnemy.transform.position = spawnPosition;

        cooldownTimer += Time.deltaTime;
    }

    int MaxVerNumber()
    {
        if (Point.Score < 50)
        { return 1; }
        else if (Point.Score >= 50 && Point.Score < 250)
        { return 2; }
        else if (Point.Score >= 250)
        { return 3; }
       

           return 0;
    }
}

    




 

