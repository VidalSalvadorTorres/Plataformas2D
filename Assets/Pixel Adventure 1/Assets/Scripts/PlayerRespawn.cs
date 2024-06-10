using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Vector3 respawnPoint = Vector3.zero; // Punto de reaparición (0,0,0)
    public float respawnDelay = 2.0f; // Tiempo de espera antes de reaparecer
    private bool isRespawning = false;

    void Update()
    {
        // Para propósitos de prueba, presionar "R" destruirá al jugador
        if (Input.GetKeyDown(KeyCode.R))
        {
            DestroyPlayer();
        }
    }

    public void DestroyPlayer()
    {
        if (!isRespawning)
        {
            isRespawning = true;
            gameObject.SetActive(false);
            Invoke(nameof(RespawnPlayer), respawnDelay);
        }
    }

    private void RespawnPlayer()
    {
        transform.position = respawnPoint;
        gameObject.SetActive(true);
        isRespawning = false;
    }
}


