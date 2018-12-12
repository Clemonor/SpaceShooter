using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    protected float HP = 1f;
    protected float EnemySpeed = -0.05f;
    protected ScoreCounter count;

    protected SpriteRenderer Ow;

    protected Color colorOw = Color.red;
    protected Color colorFine = Color.white;

    protected virtual void Start ()
    {
        count = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ScoreCounter>();
        Ow = GetComponent<SpriteRenderer>();
	}

	protected virtual void Update ()
    {
        transform.Translate(0, EnemySpeed, 0);
    }

    protected virtual void ChangeColor()
    {
        Ow.color = colorFine;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "Player")
        {
            collision.collider.GetComponent<Movement>().Damage(3F);
            Destroy(gameObject);
        }

        else if (collision.collider.tag == "Shot")
        {
            HP = HP - 1f;
            Destroy(collision.collider.gameObject);
            Ow.color = colorOw;
            Invoke("ChangeColor", 0.2F);

            if(HP < 1)
            {
                count.Score += 10;
                Destroy(this.gameObject);
            }
        }
    }
}