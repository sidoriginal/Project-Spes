using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    public float hspeed;
    public float vspeed;
    public float amp;
    public Vector3 temppos;
    // Start is called before the first frame update
    void Start()
    {     hspeed = Random.Range(0.1f, 1.0f);
     vspeed = Random.Range(30.0f, 50.0f);
     amp = Random.Range(0.0f, 0.1f);
    temppos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        temppos.x += hspeed;
        temppos.y +=Mathf.Sin(Time.realtimeSinceStartup*vspeed)*amp;
        transform.position = temppos;
    }
}
