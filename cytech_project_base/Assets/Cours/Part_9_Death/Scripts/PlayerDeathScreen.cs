using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathScreen : MonoBehaviour
{
    // Canvas
    [SerializeField] private Canvas deathScreenCanvas = null;

    // Retrieve the Player Health component
    [SerializeField] private PlayerHealth playerHealth = null;
    private PlayerHealth PlayerHealth
    {
        get
        {
            if (this.playerHealth == null)
                this.playerHealth = this.GetComponentInParent<PlayerHealth>();
            return this.playerHealth;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.deathScreenCanvas != null && this.PlayerHealth != null)
        {
            this.deathScreenCanvas.enabled = (this.PlayerHealth.isAlive == false);
        }
    }
}
