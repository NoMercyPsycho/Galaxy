using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public Transform leftpoint;
    public Transform rightpoint;
    public int speed = 2;
    private bool isMoving = true;

    void Update()
    {
        if (isMoving && Vector3.Distance(transform.position, rightpoint.position) < 1f)
        {
            isMoving = false;
        }
        else if (!isMoving && Vector3.Distance(transform.position, leftpoint.position) < 1f)
        {
            isMoving = true;
        }

        Vector3 direction = isMoving ? leftpoint.position - transform.position : rightpoint.position - transform.position;
        transform.position += direction.normalized * Time.deltaTime * speed;
    }
}