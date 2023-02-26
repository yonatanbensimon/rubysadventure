using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem healthEffect;
    public AudioClip collectedClip;
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if ((controller != null) & (controller.health < controller.maxHealth))
        {
            controller.changeHealth(1);
            Destroy(gameObject);
            Instantiate(healthEffect, transform.position, Quaternion.identity);
            controller.PlaySound(collectedClip);
        }
    }
}
