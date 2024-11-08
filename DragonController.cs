using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    [SerializeField] private float speed;
    private FixedJoystick fixedJoystick;
    private Rigidbody rigidBody;

    private void OnEnable()
    {
        // Finds and assigns the joystick control in the scene.
        fixedJoystick = FindObjectOfType<FixedJoystick>();

        // Assigns the Rigidbody component attached to the dragon GameObject.
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Retrieves the horizontal and vertical input values from the joystick.
        float xVal = fixedJoystick.Horizontal;
        float yVal = fixedJoystick.Vertical;

        // Creates a movement vector based on joystick input, applying speed to set the velocity.
        Vector3 movement = new Vector3(xVal, 0, yVal);
        rigidBody.velocity = movement * speed;

        // Rotates the dragon to face the movement direction when there is joystick input.
        if (xVal != 0 && yVal != 0)
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(xVal, yVal) * Mathf.Rad2Deg, transform.eulerAngles.z);
    }
}
