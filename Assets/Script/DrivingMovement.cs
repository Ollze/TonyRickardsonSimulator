using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingMovement : MonoBehaviour
{
    private float speed = 0;
    private float minSpeed = -2;
    private float maxSpeed = 8;
    private float rotationSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speed > 0)
        {
            speed -= 2f * Time.deltaTime;//friction basically
        }
        if (speed < 0)
        {
            speed += 2f * Time.deltaTime;//friction om man backar
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (speed < maxSpeed)
            {
                speed += 4f * Time.deltaTime; //acceleration
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (speed > minSpeed)
            {
                speed -= 5f * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveRight();
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveLeft();
        }

        moveSpeed();
    }
    private void moveSpeed()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    private void moveRight()
    {
        if (speed > 0.1f || speed < -0.1f)
        {
            transform.Rotate(0, 0, -rotationSpeed * speed * Time.deltaTime);
        }
    }
    private void moveLeft()
    {
        if (speed > 0.1f || speed < -0.1f)
        {
            transform.Rotate(0, 0, rotationSpeed * speed * Time.deltaTime);
        }
    }
}
