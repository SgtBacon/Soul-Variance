using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char1 : MonoBehaviour
{
    public int Health;
    public string Name;
    Rigidbody2D rb;
    public float speed;
    public Vector2 JumpHeight;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    //Move Function called by Update(), moved for readability
    //Update function when adding Options menu so that User can change their button mapping
    public void Move()
    {
        float x = Input.GetAxis("Left_Right");
        float MoveBy = x * speed;
        rb.velocity = new Vector2(MoveBy, rb.velocity.y);

        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(JumpHeight, ForceMode2D.Impulse);
        }
    }
}
