using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a specific tag or object if needed
        // if (collision.gameObject.CompareTag("YourTag"))

    }

    // If using trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Destroy the VFX object
        Destroy(gameObject);
    }
}
