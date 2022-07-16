using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTaker : MonoBehaviour
{
    public int place;
    private float time;

    GameObject spawner;

    void OnTriggerStay2D(Collider2D collide)
    {
        if (collide.gameObject.CompareTag("Client"))
        {
            Spawn.pos[place] = true;
        }
    }
    void OnTriggerExit2D(Collider2D collide)
    {
        if (collide.gameObject.CompareTag("Client"))
        {
            Spawn.pos[place] = false;
        }
    }
}
