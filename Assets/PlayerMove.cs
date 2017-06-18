using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed;
    public float Jump;

	void Update ()
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.z = -10;
        Camera.main.transform.position = cameraPosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, Jump));
        }

        Vector2 velocity = new Vector2();

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x = -Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x = Speed;
        }

        velocity.y = GetComponent<Rigidbody2D>().velocity.y;
        
        GetComponent<Rigidbody2D>().velocity = velocity;
	}
}
