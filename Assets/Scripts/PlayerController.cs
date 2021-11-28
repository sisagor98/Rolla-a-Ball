using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    [Space(10)]
    public float moveSpeed;
    public float turnSmoothTime = .1f;
    private float turnSmoothVelocity;

    public Transform gfx;

    [Space(10)]
    [Header("Joysticks")]
    public VariableJoystick joystick;

    private void Update()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude > .01f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);


            transform.position += moveSpeed * Time.deltaTime * direction;
            //controller.Move(moveSpeed * Time.deltaTime * direction);
        }

    }


}
