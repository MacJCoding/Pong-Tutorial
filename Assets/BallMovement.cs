using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
	bool gameStarted = false;
	bool isGoingRight = true;
	public bool isGoingUp = true;
	
    void FixedUpdate()
    {
        if(!gameStarted && Input.GetKey(KeyCode.Space))
		{
			gameStarted = true;
		}
		if(gameStarted)
		{
			if(isGoingRight)
			{
				transform.Translate(0.1f,0f,0f);
			} else {
				transform.Translate(-0.1f,0f,0f);
			}
			if(isGoingUp)
			{
				transform.Translate(0f,0.1f,0f);
			} else {
				transform.Translate(0f,-0.1f,0f);
			}
		}
		if(transform.position.x > 10 || transform.position.x < -10)
		{
			gameStarted = false;
			transform.position = new Vector3(0f,0f,0f);
		}
    }
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Panel")
		{
			isGoingRight = !isGoingRight;
		}
		if(col.gameObject.tag == "Boundary")
		{
			isGoingUp = !isGoingUp;
		}
	}
}
