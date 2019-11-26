using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turrent : MonoBehaviour
{
    public Transform firePoint;
    public GameObject lazerPrefab;
    public float speed = 20f;
    public Transform target;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.right = target.position - transform.position;

        //if (Input.GetKey("x"))
        //{

        //transform.LookAt(target); //it disappears
        Shoot();

        //}
    }
    void Shoot()
    {
        Instantiate(lazerPrefab, firePoint.position, firePoint.rotation);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.gameObject.tag == "Player" || other.gameObject.tag == "wall")
        //{
        //    Debug.Log("collision detected!");
        //    Destroy(gameObject);
        //}
    }
}
