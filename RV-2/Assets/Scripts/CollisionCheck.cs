using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour {

    public bool colliding;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CollisionCheck")
            colliding = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "CollisionCheck")
            colliding = false;
    }
}
