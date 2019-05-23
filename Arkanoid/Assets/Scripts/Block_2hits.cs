using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_2hits : MonoBehaviour
{
    public Rigidbody2D ball;
    public Sprite Block_Broken_1;
    public Sprite Block_Broken_2;
    

    public int hitsNeeded = 2;
    public int hitsTaken;



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
