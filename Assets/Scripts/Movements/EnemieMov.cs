using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieMov : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveDistance = 4f;
    public float descendAmount = 0.5f;

    private Vector3 startPos;
    private bool movDer = true;
    private float distanciaMovida = 0f;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Mover en horizontal
        float direction = movDer ? 1f : -1f;
        float movement = direction * moveSpeed * Time.deltaTime;

        // Mover en horizontal
        transform.position += new Vector3(movement, 0f, 0f);
        distanciaMovida += Mathf.Abs(movement);


        if (distanciaMovida >= moveDistance)
        {
            movDer = !movDer;
            distanciaMovida = 0f;


            transform.position += new Vector3(0f, -descendAmount, 0f);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "WallCollider")
        {
            moveSpeed *= -1f;
        }
    }
}