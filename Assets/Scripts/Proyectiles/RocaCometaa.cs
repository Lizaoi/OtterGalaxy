using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocaCometaa : MonoBehaviour
{
    public float moveSpeed = 2f; // Velocidad de movimiento de la roca
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime); // Mueve la roca hacia arriba   
    }
     
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemigo") // Si la roca colisiona con un objeto que tiene el tag "Enemigo"
        {
            Destroy(collision.gameObject); // Destruye el objeto enemigo
            Destroy(gameObject); // Destruye la roca
        }

    }
}

