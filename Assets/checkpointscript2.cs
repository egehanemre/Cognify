using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointscript2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MoveRespawnPoint();
        }
    }

    private void MoveRespawnPoint()
    {
        GameObject respawnPoint = GameObject.Find("Respawn");
        GameObject checkpoint = GameObject.Find("CheckPoint2");

        if (respawnPoint != null && checkpoint != null)
        {
            respawnPoint.transform.position = checkpoint.transform.position;
        }
        else
        {
            Debug.LogError("Respawn point or checkpoint not found!");
        }
    }
}