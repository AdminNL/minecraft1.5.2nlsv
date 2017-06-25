using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class NewBehaviourScript : MonoBehaviour {

    public Rigidbody2D rb2d;
    public float jumpSpeedForce = 0f;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D> ();
		jumpSpeedForce = 8.0f;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var raycast = Physics2D.RaycastAll(transform.position, new Vector2(0.0f, -1.0f), 1.0f);

            if (raycast.Length >= 2)
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(Vector2.up * jumpSpeedForce, ForceMode2D.Impulse);
            }
        }
    }
}
