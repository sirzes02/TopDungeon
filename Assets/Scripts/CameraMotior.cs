using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotior : MonoBehaviour
{
    public Transform looakAt;
    public float boundX = 0.15f;
    public float boundY = 0.05f;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        float deltaX = looakAt.position.x - transform.position.x;
        if (deltaX > boundX || deltaX < -boundX)
        {
            if (transform.position.x < looakAt.position.x)
            {
                deltaX -= boundX;
            }
            else
            {
                deltaX += boundX;
            }
        }

        float deltaY = looakAt.position.y - transform.position.y;
        if (deltaY > boundY || deltaY < -boundY)
        {
            if (transform.position.y < looakAt.position.y)
            {
                deltaY -= boundY;
            }
            else
            {
                deltaY += boundY;
            }
        }

        transform.position += new Vector3(deltaX, deltaY, 0);
    }

}
