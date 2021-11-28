using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{

    public VariableJoystick joystick;
    private float horizontal=5f;
    public float moveSpeed = 5f;
    public Rigidbody rb;
    private int coinCount;

    

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(joystick.Horizontal * moveSpeed, rb.velocity.y, joystick.Vertical * moveSpeed);
        if (joystick.Horizontal !=0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.identity;
           // transform.rotation = Quaternion.LookRotation(rb.velocity);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
           
           other.gameObject.SetActive(false);
           coinCount++;
           checkCoin();
        }
        if (other.tag == "BOOM")
        {
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            UiManager.Instance.LoadLevelFailed();

        }
    }

    private void checkCoin()
    {
        if (coinCount == 8)
        {
            UiManager.Instance.LoadLevelComplete();
        }
    }




}
