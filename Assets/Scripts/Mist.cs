using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mist : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    Rigidbody2D flRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        flRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 mvmt = mousePosition - transform.position;
        flRigidbody.AddForce(mvmt);
        //transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }
}
