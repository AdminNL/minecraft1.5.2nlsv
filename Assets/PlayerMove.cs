using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed;
    public float Jump;

    void FixedUpdate()
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.z = -10;
        Camera.main.transform.position = cameraPosition;

        Vector2 velocity = new Vector2();

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x = -Speed;
            Vector3 pos = transform.position;
            pos.x -= Speed * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x = Speed;
            Vector3 pos = transform.position;
            pos.x += Speed * Time.deltaTime;
            transform.position = pos;
        }
	}
}
