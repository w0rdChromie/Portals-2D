using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//credit to Blackthornprod for the inspiration for this code
public class portalScript : MonoBehaviour
{
    private Vector2 target;
    private Transform portal1;
    private Transform portal2;

    // Start is called before the first frame update
    void Start()
    {
        portal1 = GameObject.FindGameObjectWithTag("Portal1").GetComponent<Transform>();
        portal2 = GameObject.FindGameObjectWithTag("Portal2").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            portal1.position = new Vector2(target.x, target.y);
        }
        else if (Input.GetMouseButtonDown(1)) {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            portal2.position = new Vector2(target.x, target.y);
        }
    }
}
