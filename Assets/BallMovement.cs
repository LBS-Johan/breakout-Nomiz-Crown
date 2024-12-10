using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.gravityScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5f;
        myRigidbody.velocity = myRigidbody.velocity.normalized * speed;

        //if Transform.position.y < 5 

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        myRigidbody.gravityScale = 0;
        //print(myRigidbody.gravityScale);
    }
}
