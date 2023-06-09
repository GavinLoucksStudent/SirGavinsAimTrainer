using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnBoundary : MonoBehaviour
{
    [SerializeField] Transform wp1;
    [SerializeField] Transform wp2;
    [SerializeField] Transform wp3;
    [SerializeField] Transform wp4;

    public int amountOfTargets = 3;

    float xRan = 75f;
    float yRan = 0f;

    [SerializeField] GameObject Target;
    void Start()
    {

       



    }



    void Update()
    {

        if (amountOfTargets < 3)
        {
            Spawn();
           
        }
    }

    void Spawn()
    {
       
       
            
            xRan = Random.Range(wp1.position.x, wp2.position.x);
            yRan = Random.Range(wp1.position.y, wp4.position.y);

            Vector3 pos = new Vector3(xRan,yRan,wp1.position.z);


            Instantiate(Target, pos, Quaternion.identity);
            amountOfTargets++;
    }
}
