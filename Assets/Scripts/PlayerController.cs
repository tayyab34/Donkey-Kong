using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15f;
    private float force = 15f;
    private Rigidbody2D playerRb;
    private GameManager gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player Movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation=Quaternion.Euler(new Vector3(0, 180, 0));
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        //Player Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Player Ignore collision when collide with stairs
        if (collision.gameObject.CompareTag("Stairs"))
        {
         Physics.IgnoreCollision(collision.gameObject.GetComponent<BoxCollider>(),GetComponent<BoxCollider>());
        }
    }
}
