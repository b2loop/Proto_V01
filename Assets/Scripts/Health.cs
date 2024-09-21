using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float HP = 100;
    public bool isPlayer = false; // Set to true for the player
    public GameManager gameManager; // Assign this in the inspector


    // Apply damage
    public void TakeDamage(float amount)
    {
        HP -= amount;
        if (HP <= 0)
        {
            Die();
        }
    }

    // Death method
    private void Die()
    {
        if (isPlayer)
        {
            // trigger game over logic on player death
            if (gameManager != null)
            {
                gameManager.GameOver();
            }

        }
        else
        {
            // trigger victory logic on enemy death
            if (gameManager != null)
            {
                gameManager.Victory();
            }
        }


        {
            Destroy(gameObject);
        }
       
    }

}
