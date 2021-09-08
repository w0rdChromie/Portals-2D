using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float pSpeed;
    private Vector2 pVelocity;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        pVelocity = movementInput.normalized * pSpeed;
    }

    void FixedUpdate() {

        rb2d.MovePosition(rb2d.position + pVelocity * Time.fixedDeltaTime);
    
    }
}
