using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy(other.gameObject);

        //Destroy(gameObject); //works

        //if (other.gameObject.tag == "turrent")
        //{
        //    Destroy(gameObject);
        //}

       // Debug.Log("collision!");
        if (other.gameObject.tag == "turrent" || other.gameObject.tag == "wall")
        {
            Debug.Log("collision detected!");
            Destroy(gameObject);
        }
    }
}
