using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boss : MonoBehaviour
{
    public Health health;

    public Transform player;

    public bool isFlipped = false;

    [SerializeField] private AudioClip damageSoundClip;

    void Start()
    {
        health = GetComponent<Health>();
    }




    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if (transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x < player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }

    public void Damage(float damageAmount)
    {
        //play soundFX
        SFXManager.instance.PlaySoundFXClip(damageSoundClip, transform, 1f);
    }

}