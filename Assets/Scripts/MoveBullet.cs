using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public int speed = 50;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
