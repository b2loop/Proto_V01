using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject spellPrefab; // The spell to cast
    public Transform spellSpawnPoint; // Where to spawn the spell

    // This method will be called by the Animation Event
    public void CastSpell()
    {
        if (spellPrefab != null && spellSpawnPoint != null)
        {
            Instantiate(spellPrefab, spellSpawnPoint.position, spellSpawnPoint.rotation);
        }
    }
}
