using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSystem : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;

        if (Input.GetKey("w"))
        {
            currentPosition.y += speed;
        }
        if (Input.GetKey("d"))
        {
            currentPosition.x += speed;
        }
        if (Input.GetKey("s"))
        {
            currentPosition.y -= speed;
        }
        if (Input.GetKey("a"))
        {
            currentPosition.x -= speed;
        }

        transform.position = currentPosition;
    }
}
