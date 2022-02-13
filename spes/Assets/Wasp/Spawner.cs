using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public destroyer dest;
    public GameObject Wasp;
    public int xpos;
    public int zpos;
    public int ypos;
    public static int quan;
    public int gen;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenObj());

    }

    IEnumerator GenObj()
    {
    
        while (quan<999999999)
        {
          
            xpos = Random.Range(-121, -109);
            zpos = Random.Range(14, 150);
            ypos = Random.Range(10, 41);
            Instantiate(Wasp, new Vector3(xpos, ypos, zpos), Quaternion.identity);
            yield return new WaitForSeconds(1.3f);
            quan = quan + 1;
        }

      
    }



 

}
