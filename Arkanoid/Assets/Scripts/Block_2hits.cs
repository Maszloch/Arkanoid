using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_2hits : MonoBehaviour
{
    public Rigidbody2D ball;
    public Sprite Block_Square;
    public Sprite Block_Broken_1;
    public Sprite Block_Broken_2;
    private SpriteRenderer cc;

    public int hitsNeeded = 3;
    public int hitsTaken;


    void Start()
    {
        hitsTaken = 0;
        cc = GetComponent<SpriteRenderer>();
       
    }


    void Update()
    {
        if (hitsTaken == 1)
        {
            cc.sprite = Block_Broken_1;
        }

        if (hitsTaken == 2)
        {
            cc.sprite = Block_Broken_2;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        hitsTaken += 1;
        ball.velocity = new Vector2(ball.velocity.x, -ball.velocity.y);

        if (hitsTaken >= hitsNeeded)
        {
            Destroy(gameObject); 
        }
        
        
    }
}
