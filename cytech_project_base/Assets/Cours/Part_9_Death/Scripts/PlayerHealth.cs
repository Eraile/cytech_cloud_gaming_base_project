using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public bool isAlive = true;

    public void Die()
    {
        this.isAlive = false;
        Debug.LogWarning("JE SUIS MORT");
    }
}
