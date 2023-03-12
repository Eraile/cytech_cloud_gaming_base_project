using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public Transform target = null;
    public float speedFactor = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // Calculate new position
        //Vector3 newPosition = this.target.position;
        Vector3 newPosition = Vector3.Lerp(this.transform.position, this.target.position, Time.deltaTime * speedFactor);

        // Fix position
        newPosition.z = this.transform.position.z;

        // Set new position
        this.transform.position = newPosition;
    }

    public void OnPlayerDead()
    {
        this.enabled = false;
    }

    public void OnPlayerAlive()
    {
        this.enabled = true;
    }
}
