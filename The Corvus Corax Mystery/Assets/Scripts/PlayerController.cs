using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed;
    public float jumpForce;

    // Essentially the air resistance acting on your player
    public float movementResistance;

    // Gravity acting on the player
    public float gravityMultiplier;

    // Player's rigidbody
    private Rigidbody2D rb;

    void Start()
    {
        // Multiply the gravity by the gravity multiplier
        Physics2D.gravity *= gravityMultiplier;

        // Set the players rigidbody to the players super stiff body ;)
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get tu mama es muy grande inputs
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Make player go zoom zoom
        rb.AddForce(new Vector2(horizontalInput * playerSpeed, 0), ForceMode2D.Impulse);

        // Add the resistaunce <- plz pretend thats french
        rb.AddForce(new Vector2(-rb.velocity.x * movementResistance, 0), ForceMode2D.Impulse);
    }
}
