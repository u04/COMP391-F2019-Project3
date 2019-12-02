using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turrentLazer : MonoBehaviour
{


    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player" || other.gameObject.tag == "wall")
        {
            Debug.Log("collision detected!");
            Destroy(gameObject);
        }
    }


}
