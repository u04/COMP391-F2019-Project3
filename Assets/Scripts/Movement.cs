﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Transform firePoint;
    public GameObject lazerPrefab;
    public Text scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKey("space"))
        {
            Shoot();
            
        }
    }
    void Shoot()
    {
        Instantiate(lazerPrefab, firePoint.position, firePoint.rotation);
    }
    public void Move()
    {
       
        if (Input.GetKey("d"))
        {
            transform.Rotate(transform.forward * -5);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(transform.forward * 5);
        }
        if (Input.GetKey("w"))
        {
            transform.position += transform.up * Time.deltaTime * 3f;
        }
        if (Input.GetKey("s"))
        {
            transform.position += transform.up * Time.deltaTime * -3f;
        }
    
        


    }
    int counter = 0;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "laser")
        {
            counter++;
            //Debug.Log(counter);
            scoreText.text = "Count: " + counter.ToString();
        }
    }

}
