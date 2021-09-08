using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//credit to Blackthornprod for the inspiration for this code

public class teleportScript : MonoBehaviour
{
    private Transform destination;
    public bool isPortal2;
    public float distance = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        if (isPortal2 == false) {
            destination = GameObject.FindGameObjectWithTag("Portal2").GetComponent<Transform>();
        } else {
            destination = GameObject.FindGameObjectWithTag("Portal1").GetComponent<Transform>();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (Vector2.Distance(transform.position, other.transform.position) > distance) {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
        }
    }
}
