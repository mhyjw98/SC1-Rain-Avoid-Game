using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtan : MonoBehaviour
{
    float direction = 0.005f;
    float toward = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            toward *= -1;
            direction *= -1;
        }
        if (transform.position.x > 2.8f)
        {
            direction = -0.005f;;
            toward = -1.0f;
        }
        if (transform.position.x < -2.8f)
        {
            direction = 0.005f;
            toward = 1.0f;
        }
        transform.localScale = new Vector3(toward, 1, 1);
        transform.position += new Vector3(direction, 0, 0);
    }
}
  
