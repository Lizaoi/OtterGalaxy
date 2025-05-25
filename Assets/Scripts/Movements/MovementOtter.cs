using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOtter : MonoBehaviour
{
    [SerializeField]private float speed;
    public GameObject bulletPrefab; // Arrastrás tu prefab desde Unity
    public Transform PuntoLanzar;     // Un objeto vacío como punto de disparo
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Lanzar();
        }

        if (Input.GetKey(KeyCode.D)) //Vector3(X, Y)
        {
            transform.Translate(new Vector2(1, 0)*speed*Time.deltaTime); //Vector2 (X, y)
        } else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-1, 0) * speed * Time.deltaTime);
        }
        
    }
    void Lanzar()
    {
        Instantiate(bulletPrefab, PuntoLanzar.position, Quaternion.identity);
    }
}
