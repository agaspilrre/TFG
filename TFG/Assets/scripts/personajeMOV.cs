using UnityEngine;
using System.Collections;

public class personajeMOV : MonoBehaviour {

    public float speed = 10f;
    float movex = 0f;

    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movex = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movex * speed,0);


        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector2(0, 100), ForceMode2D.Impulse);
        }

    }
}
