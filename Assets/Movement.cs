using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 0.5f;
    Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.gravityScale = 0;
        myRigidbody.mass = 1;
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            myRigidbody.velocity = new Vector3(1, 0) * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            myRigidbody.velocity = new Vector3(-1, 0) * speed;
        }
    }
}
