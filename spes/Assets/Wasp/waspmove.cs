using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class waspmove : MonoBehaviour
{
    public float timer;
    public int newtarget;
    public float speed;
    public UnityEngine.AI.NavMeshAgent nav;
    UnityEngine.AI.NavMeshPath path;
    public Vector3 Target;
    bool inco;
    bool valpath;
    // Start is called before the first frame update
    void Start()
    {   
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        nav.speed = speed*1000000;
        path = new NavMeshPath();
    }
    void Update()
    {
        if (!inco)
        {
            StartCoroutine(some());
        }
    }
    Vector3 Getrand()
    {
        float x = Random.Range(-100, 100);
        float y = Random.Range(2, 100);
        float z =  Random.Range(-100, 100);

        Vector3 pos = new Vector3(x, y, z);
        return pos;
    }

    IEnumerator some()
    {
        inco = true;
        yield return new WaitForSeconds(timer);
        Getpath();
        valpath = nav.CalculatePath(Target, path);
  

        while (!valpath)
        {
            yield return new WaitForSeconds(0.01f);
            Getpath();
            valpath = nav.CalculatePath(Target, path);
        }
        inco = false;
    }
    // Update is called once per frame

    void Getpath()
    {
        Target = Getrand();
        nav.SetDestination(Target);
    }

}
