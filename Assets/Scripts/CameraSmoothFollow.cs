using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoothFollow : MonoBehaviour
{
    public Transform obj;

    public float followSpeed = 0.1f;
    public Vector3 offsetPos;


    private void FixedUpdate()
    {
        Vector3 desPos = obj.position + offsetPos;
        Vector3 afterPos = Vector3.Lerp(transform.position, desPos, followSpeed);
        transform.position = afterPos;
    }
}
