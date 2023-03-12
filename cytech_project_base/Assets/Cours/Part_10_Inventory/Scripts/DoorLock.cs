using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    [SerializeField] private Door door = null;
    public Door Door
    {
        get
        {
            if (this.door == null)
                this.door = this.GetComponentInParent<Door>();
            return this.door;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == null)
            return;
        if (this.Door == null || this.Door.IsLocked == false)
            return;

        PlayerInventory playerInventory = collision.gameObject.GetComponentInParent<PlayerInventory>();
        if (playerInventory != null)
        {
            if (playerInventory.keysCount > 0)
            {
                playerInventory.keysCount--;
                this.Door.Unlock();

                // Delete self
                GameObject.Destroy(this.gameObject);
            }
        }
    }
}
