using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class destroyer : MonoBehaviour
{
    //public GameObject Wasp=gameObject
    public Spawner spawner;
    int getx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
            if (gameObject.name=="Wasp(Clone)"&&gameObject.transform.position.x > 160.0f)
            {
                Destroy(gameObject);
            }
        
    }
}
