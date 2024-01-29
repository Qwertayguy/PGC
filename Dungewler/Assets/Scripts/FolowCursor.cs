using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowCursor : MonoBehaviour
{
    public float speed = 5.0f; // Adjust the speed as needed.
    public Transform MirrorMouse;
    public Transform Self;
    public Animator animator;
    SpriteRenderer spriteRenderer;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void FixedUpdate()
    {
        Quaternion ownRotation = Self.rotation;
        // Get the current mouse position in the world space.
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorPosition.z = 0; // Ensure the object stays on the 2D plane.

        // Calculate the direction from the object to the cursor.
        Vector3 direction = cursorPosition - transform.position;

        // Normalize the direction to have a magnitude of 1, then multiply by the speed.
        Vector3 moveAmount = direction.normalized * speed * Time.deltaTime;

        

        if (Input.GetButton("Fire1"))
        {

            // Update the object's position based on the direction and speed.
            transform.Translate(moveAmount);
            animator.SetBool("IsWalking", false);
            if (Input.mousePosition.x > 1900)
            {
                spriteRenderer.flipX = false;
            }
            else
            {
                spriteRenderer.flipX = true;
            }
        }
        else
        {
            animator.SetBool("IsWalking", true);
        }
    }
}