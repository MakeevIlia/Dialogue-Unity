using System.Collections;
using System.Collections.Generic;
using UnityEngine;





[RequireComponent(typeof(Rigidbody2D))]
public class MovementController : MonoBehaviour
{
    private float speed = 4.0f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Vector2 movement = rb2d.velocity;
        movement.x = h * speed;
        rb2d.velocity = movement;
    }
}
