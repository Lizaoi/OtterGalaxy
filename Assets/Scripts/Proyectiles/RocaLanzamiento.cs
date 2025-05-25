using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocaLanzamiento : MonoBehaviour
{
    public float moveSpeed; // Velocidad de movimiento de la roca
    public GameObject RocaPrefab; // Prefab de la roca que se lanzará
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime); // Mueve la roca hacia arriba
        if (Input.GetButtonDown("Fire1")) // Si se presiona la tecla de espacio
        {
            Instantiate(RocaPrefab, transform.position, Quaternion.identity); // Instancia la roca en la posición del jugador
        }
    }
}
