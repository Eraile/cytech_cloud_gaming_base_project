using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Spawn position
    private Vector3 spawnPosition = Vector3.zero;

    // Alive status
    public bool isAlive = true;

    // Callbacks
    public UnityEngine.Events.UnityEvent OnPlayerDied = new UnityEngine.Events.UnityEvent();
    public UnityEngine.Events.UnityEvent OnPlayerRevived = new UnityEngine.Events.UnityEvent();

    private void Start()
    {
        this.spawnPosition = this.transform.position;
    }

    public void Die()
    {
        // Ignore if alive
        if (this.isAlive == false)
            return;

        // Update status
        this.isAlive = false;
        Debug.LogWarning("JE SUIS MORT");

        // Callback
        this.OnPlayerDied.Invoke();
    }

    public void Revive()
    {
        // Ignore if alive
        if (this.isAlive == true)
            return;

        // Reset position
        this.transform.position = this.spawnPosition;
        
        // Update status
        this.isAlive = true;
        Debug.LogWarning("JE VIENS DE RESSUSCITER");

        // Callback
        this.OnPlayerRevived.Invoke();
    }
}
