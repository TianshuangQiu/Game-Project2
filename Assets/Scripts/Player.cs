using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.SceneManagement;
=======
<<<<<<< HEAD
using UnityEngine.SceneManagement;
=======
>>>>>>> refs/remotes/origin/main
>>>>>>> origin/main

public class Player : MonoBehaviour
{
    Rigidbody2D playerRigidbody;

    float xAxis;
    float yAxis;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        yAxis = Input.GetAxisRaw("Vertical");

        Move();
    }

    void Move()
    {
        Vector2 movementVector = new Vector2(xAxis, yAxis);
        playerRigidbody.velocity = movementVector;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Exit"))
        {
            Die();
<<<<<<< HEAD
            SceneManager.LoadScene("VictoryScene");
        } else if (collision.gameObject.CompareTag("Laser"))
        {
            Die();
            SceneManager.LoadScene("DeadScene");
=======
<<<<<<< HEAD
            SceneManager.LoadScene("VictoryScene");
        } else if (collision.gameObject.CompareTag("Laser"))
        {
            Die();
            SceneManager.LoadScene("DeadScene");
=======
            Debug.Log("NEXT LEVEL");
        } else if (collision.gameObject.CompareTag("Laser"))
        {
            Die();
            Debug.Log("I'm dead lul");
>>>>>>> refs/remotes/origin/main
>>>>>>> origin/main
        }
        
    }
    

    void Die()
    {
        Destroy(this.gameObject);
    }
}
