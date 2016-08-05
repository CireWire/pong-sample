using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour {

    public float speed = 30f; //This is the speed of the rackets.
    public string axis = "Vertical"; //To change the input axis in the inspector.

	// Use this for initialization
	void FixedUpdate () {

        float v = Input.GetAxisRaw(axis); //Will be using GetAxisRaw to easily record the input of (v)ertical.
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed; //Calling Rigidbody2D and grabbing its velocity.
	
	}
	
}
