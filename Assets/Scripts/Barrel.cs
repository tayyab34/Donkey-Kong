using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Barrel: MonoBehaviour
{
    private Rigidbody2D barrelRb;
    private float force = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        barrelRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        barrelRb.AddForce(Vector2.right * force,ForceMode2D.Impulse);
    }
}
