using UnityEngine;
using System.Collections;

public class bat1Controller : MonoBehaviour
{

    // Use this for initialization

    private Rigidbody2D rb;//declare the variable first so that only this script can access our rigid body(private)


    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();//only this script can access our rigid body component
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0f, 5f);
        }
        else if (Input.GetKey(KeyCode.S))

        {
            rb.velocity = new Vector2(0f, -5f);

        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }
}