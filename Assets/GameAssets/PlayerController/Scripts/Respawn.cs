using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TarodevController;

public class Respawn : MonoBehaviour
{
    public Transform respawnpoint;
    private TrailRenderer trail;
    private void Awake()
    {
        trail = FindObjectOfType<TrailRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.position = respawnpoint.position;
            trail.time = 0;
            Invoke(nameof(Resettrial),0.3f);
            Camera.main.transform.position = respawnpoint.position + Vector3.back*1f;
        }
    }

    private void Resettrial() 
    {
        trail.time = 1;
    }

}