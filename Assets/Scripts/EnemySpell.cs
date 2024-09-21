using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpell : MonoBehaviour
{
    public float speed = 15f;
    public float damage = 10f;
    public float lifespan = 2f;

    private void Start()
    {
        Destroy(gameObject, lifespan); 
    }



    private void OnTriggerEnter(Collider other)
    {
        // can check for tags or conditions here
        // if (collision.gameObject.CompareTag("Enemy"))
        // {
        //     // collision with enemies
        // }

        if (other.gameObject.CompareTag("Player"))
        {
            Health health = other.gameObject.GetComponent<Health>();

            // check for Health component
            if (health != null)

            {
                // apply damage to health component
                health.TakeDamage(damage);
            }

        }

        else
        {
            Destroy(gameObject);
        }

    }
}
