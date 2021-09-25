using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D playerRigidbody;

    float xAxis;
    float yAxis;
    float movementSpeed;
    float health;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        movementSpeed = 1.5f;
        health = 2;
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
        playerRigidbody.velocity = movementVector * movementSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Exit"))
        {
            SceneManager.LoadScene("VictoryScene");
        }
        else if (collision.gameObject.CompareTag("Lv1"))
        {
            SceneManager.LoadScene("Level1");
        }
        else if (collision.gameObject.CompareTag("Lv2"))
        {
            SceneManager.LoadScene("Level2");
        }
        else if (collision.gameObject.CompareTag("Laser"))
        {
            takeDamage();
        }
         
    }

    void takeDamage()
    {
        health -= 1;
        if(health <= 0)
        {
            Die();
        }
        movementSpeed *= 2;
        fadeIn();
    }

    void Die()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene("DeadScene");

    }

    void fadeIn()
    {
        var arr = GameObject.FindGameObjectsWithTag("Heal");
        foreach (var x in arr)
        {
            x.GetComponent<UIHandler>().fadeIn();
        }
    }

    void fadeOut()
    {
        var arr = GameObject.FindGameObjectsWithTag("Heal");
        foreach (var x in arr)
        {
            x.GetComponent<UIHandler>().fadeOut();
        }
    }
}
