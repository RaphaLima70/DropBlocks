using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public float acelerationScale = 20;

    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / acelerationScale; 
    }

    void Update()
    {
        if (transform.position.y < -2)
        {
            Destroy(this);
        }
    }
}
