using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpellSpawn : MonoBehaviour
{
    public GameObject spellPrefab; // spell to cast
    public Transform playerTransform; // reference to player transform
    public float delay = 2.0f; // delay before spawning the spell
    
    private Vector3 spawnPosition; // to store the spawn position

    // this method will be called by the Animation Event
    public void EnemyCast()
    {
        // record player position at the moment of casting
        spawnPosition = playerTransform.position;

        // start the coroutine to handle spawn delay
        StartCoroutine(SpawnSpellAfterDelay());
    }

    private IEnumerator SpawnSpellAfterDelay()
    {
        yield return new WaitForSeconds(delay); // wait for specified delay

        if (spellPrefab != null)
        {
            // instantiate spell gameobject at the recorded position
            Instantiate(spellPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
