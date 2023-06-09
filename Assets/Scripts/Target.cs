using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SubsystemsImplementation;

public class Target : MonoBehaviour
{
    public float health = 10f;
    

   public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            Die();
        }
    }


    void Die()
    {
        Destroy(gameObject);
        FindObjectOfType<SpawnBoundary>().amountOfTargets--;
        FindObjectOfType<Gun>().AddScore();
    }
}
