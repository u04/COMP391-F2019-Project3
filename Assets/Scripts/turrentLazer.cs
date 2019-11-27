using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turrentLazer : MonoBehaviour
{
    private int currentScore = 0;
    public Text scoreText;

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
    int a = 0;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player" || other.gameObject.tag == "wall")
        {
            //Debug.Log("collision detected!");
            Destroy(gameObject);
            if (other.gameObject.CompareTag("player"))
            {
                //other.gameObject.SetActive(false);

                currentScore = currentScore + 1;
                SetCountText();
                a = a + 1;
                Debug.Log(currentScore);

            }
        }
        

        void SetCountText()
        {
            //scoreText.text = "Count: " + currentScore.ToString();
            // Debug.Log("Count: " + currentScore.ToString());
            if (currentScore >= 12)
            {
                scoreText.text = "You Win!";
            }
        }
    }
 
}
