using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtterAttack : MonoBehaviour
{
    private GameObject attackArea = default; // Área de ataque del otter

    private bool isAttacking = false; // Indica si el otter está atacando
    private float TiempodeAtacar = 0.25f; // Tiempo que dura el ataque
    private float attackCooldown = 0f; // Tiempo de espera entre ataques
    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject; // Obtiene el área de ataque del otter
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !isAttacking) // Si se presiona el botón de ataque y no está atacando
        {
            isAttacking = true; // Cambia el estado a atacando
            attackArea.SetActive(true); // Activa el área de ataque
            attackCooldown = 0.5f; // Establece el tiempo de espera entre ataques
        }
    }
}
