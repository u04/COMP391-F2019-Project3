using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform firePoint;
    public GameObject lazerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
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
        Vector2 newPosition = transform.position;
        if (Input.GetAxis("Horizontal") > 0.0f)
        {
            newPosition += new Vector2(0.05f, 0.0f);
            transform.eulerAngles = Vector3.forward * -90;
        }
        if (Input.GetAxis("Horizontal") < 0.0f)
        {
            newPosition -= new Vector2(0.05f, 0.0f);
            transform.eulerAngles = Vector3.forward * 90;
        }
        if (Input.GetAxis("Vertical") > 0.0f)
        {
            newPosition += new Vector2(0.00f, 0.05f);
            transform.eulerAngles = Vector3.forward * 0;
        }
        if (Input.GetAxis("Vertical") < 0.0f)
        {
            newPosition -= new Vector2(0.00f, 0.05f);
            transform.eulerAngles = Vector3.forward * -180;
        }
        transform.position = newPosition;
    }
}
