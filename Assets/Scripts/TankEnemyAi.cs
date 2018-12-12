using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemyAi : EnemyAI {


    protected override void Start()
    {
        count = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ScoreCounter>();
        EnemySpeed = -0.01f;
        Ow = GetComponent<SpriteRenderer>();
        HP = 10f;
    }

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
            collision.collider.GetComponent<Movement>().Damage(11F);
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
                count.Score += 100;
                Destroy(this.gameObject);
            }
        }
    }
}
