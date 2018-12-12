using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperEnemyAI : EnemyAI {

   
    protected override void Start()
    {
        count = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ScoreCounter>();
        EnemySpeed = -0.03f;
        Ow = GetComponent<SpriteRenderer>();
        HP = 3f;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void ChangeColor()
    {
        base.ChangeColor();
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
            Invoke("ChangeColor", 0.3f);

            if (HP < 1)
            {
                count.Score += 10;
                Destroy(this.gameObject);

            }
        }
    }
}