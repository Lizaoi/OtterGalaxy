using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocaLanzamiento : MonoBehaviour
{
    public Animator animator;
    public GameObject RocaPrefab; // Prefab de la roca que se lanzará
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // Obtiene el componente Animator del jugador
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1")) // Si se presiona la tecla de espacio
        {
            Instantiate(RocaPrefab, transform.position, Quaternion.identity); // Instancia la roca en la posición del jugador
            animator.SetTrigger("Lanzar");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy") // Si la roca colisiona con un objeto que tiene el tag "Enemy"
        {
            Destroy(collision.gameObject); // Destruye la roca
        }
    }
}
