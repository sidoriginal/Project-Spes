using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class move : MonoBehaviour
{
    float sp = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Camera.main.transform.forward*Time.deltaTime*sp;
    }
}
