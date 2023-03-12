using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    // Waypoints
    public Transform start = null;
    public Transform end = null;

    // Speed of the platform
    public float speedFactor = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = this.start.position;
    }

    // Update is called once per frame
    public bool direction = true;   // true = start > end
    void Update()
    {
        // Are we close enough?
        Transform target = (this.direction == true ? this.end : this.start);
        if (Vector2.Distance(this.transform.position, target.position) < 0.1f)
        {
            // Switch direction
            this.direction = !this.direction;
        }
        else
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position,
                                                          target.position,
                                                          Time.deltaTime * this.speedFactor);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(this.start.position, 0.1f);
        Gizmos.DrawWireSphere(this.end.position, 0.1f);
        Gizmos.DrawLine(this.start.position, this.end.position);
    }
}
