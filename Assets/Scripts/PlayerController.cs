using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 10;
    public int rotationspeed = 50;
    private float horizontal;
    private float vertical;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontal);
        transform.Rotate(Vector3.left * rotationspeed * Time.deltaTime * vertical);
    }
}