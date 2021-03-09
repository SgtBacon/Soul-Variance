using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char1 : MonoBehaviour
{
    public int Health;
    public string Name;
    Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        float x = Input.GetAxis("Left_Right");
        float MoveBy = x * speed;
        rb.velocity = new Vector2(MoveBy, rb.velocity.y);

        float jump = Input.GetAxis("Jump");
        
    }
}
