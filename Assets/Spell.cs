using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public float speed = 15f;
    public float damage = 5f;
    public float lifespan = 2f;

    public AudioSource audioSource;
    public AudioClip hitSound;

    private void Start()
    {
        Destroy(gameObject, lifespan); // Destroy spell after its lifespan
        audioSource = GameObject.Find("SFXManager").GetComponent<AudioSource>();
    }

    private void Update()
    {
        // Move the spell forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


    private void OnCollisionEnter(Collision collision)
    {
        // can check for tags or conditions here
        // if (collision.gameObject.CompareTag("Enemy"))
        // {
        //     // collision with enemies
        // }

        if (collision.gameObject.CompareTag("Enemy"))
        {

            // Check if the audioSource and hitSound are not null
            if (audioSource != null && hitSound != null)
            {
                //play sfx
                audioSource.PlayOneShot(hitSound);
            }
            
            Health health = collision.gameObject.GetComponent<Health>();

            // Check for Health component
            if (health != null)

            {
                // Apply damage to health component
                health.TakeDamage(damage);
            }

            Destroy(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
        
    }
}
