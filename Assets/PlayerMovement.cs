using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public bool isPlayerOne = true;
	
    void FixedUpdate()
    {
		if(isPlayerOne && Input.GetKey(KeyCode.W) && transform.position.y < 3)
		{
			transform.Translate(0f, 0.1f, 0f);
		}
		if(isPlayerOne && Input.GetKey(KeyCode.S) && transform.position.y > -3)
		{
			transform.Translate(0f, -0.1f, 0f);
		}
		if(!isPlayerOne && Input.GetKey(KeyCode.UpArrow) && transform.position.y < 3)
		{
			transform.Translate(0f, 0.1f, 0f);
		}
		if(!isPlayerOne && Input.GetKey(KeyCode.DownArrow) && transform.position.y > -3)
		{
			transform.Translate(0f, -0.1f, 0f);
		}
    }
}
