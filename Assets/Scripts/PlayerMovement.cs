using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 8f; // movement speed in units per second
    private Rigidbody2D rb = null;
    private Vector2 movementInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementInput.x = Input.GetAxis("Horizontal");
        movementInput.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(movementInput, 1f) * movementSpeed;
    }
}
