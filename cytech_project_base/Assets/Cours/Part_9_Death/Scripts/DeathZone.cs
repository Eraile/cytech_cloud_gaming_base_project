using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth playerHealth = collision.GetComponentInChildren<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.Die();
        }
    }

    private void OnDrawGizmos()
    {
        Color danger = Color.red;
        danger.a = 0.5f;
        //
        Gizmos.color = danger;
        Gizmos.DrawCube(this.transform.position, this.transform.lossyScale);
    }
}
