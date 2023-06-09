
using UnityEngine;
using TMPro;


public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 10000000000f;

    public int score = 0;

    

    public Camera fpsCam;

    UIManager ui;


    void Start()
    {
        ui = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }


    void Shoot()
    {
        RaycastHit hit;
       if( Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            

           Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);

            }
        }
      
    } 

    public void AddScore()
    {

        score += 10;
        ui.UpdateScore(score);
    }
}
