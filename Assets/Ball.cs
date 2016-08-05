using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public float speed = 30f;

	// Use this for initialization
	void Start () {

        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed; //Start the game with Rigidbody initialized.
	
	}

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        /* 1 is the top of racket
         * 0 is the middle of racket
          -1 is the bottom of racket */

        // Hit the left racket?
        if (col.gameObject.name == "RacketLeft")
        {
            //Calculate hit factor
            float y = hitFactor(transform.position,
                col.transform.position, col.collider.bounds.size.y
                );
    //Calculate new direction, use normalized to make length = 1
    Vector2 dir = new Vector2(1, y).normalized;

    //Set Velocity with dir * speed
    GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        //Hit the right racket
        if (col.gameObject.name == "RacketRight") { 
        
            //Calculate the hit factor
            float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);

            //Calculate new direction, use normalized to make length = 1
            Vector2 dir = new Vector2(-1, y).normalized;

            //Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

    }
	
}
