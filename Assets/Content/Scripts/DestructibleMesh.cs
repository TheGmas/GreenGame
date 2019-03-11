using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleMesh : MonoBehaviour
{
    public GameObject destroyedVersion;
    public GameObject explosionEffect;

    public float delay = 2.0f;
    public float blastRadius = 5.0f;
    public float explosionForce = 700.0f;
    private float countdown;
    private bool hasExploded = false;

	private void Start ()
    {
        countdown = delay;
    }

    private void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0.0f && !hasExploded)
        {
            Explode(); // Calls the function.
            hasExploded = true; // Check if execute once.
        }
    }

    void Explode()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation); // Spawns in the destroyedVersion into the scene.
        Instantiate(explosionEffect, transform.position, transform.rotation); // Spawns in the particle effect into the scene.

        Collider[] colliders = Physics.OverlapSphere(transform.position, blastRadius); // Finds and gets all the nearby objects in the scene.

        foreach (Collider nearbyObject in colliders) // Loops each nearby object.
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>(); // Gets the rigidbody from the gameObjects.

            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, blastRadius); // Adds an explosion force that does the calculation for us.
            }
        }

        Destroy(gameObject);
    }
}
