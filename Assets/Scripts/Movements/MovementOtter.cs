using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOtter : MonoBehaviour
{
 
    [SerializeField]private float speed;
    public float moveSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D)) //Vector3(X, Y)
        {
            transform.Translate(new Vector2(1, 0)*speed*Time.deltaTime); //Vector2 (X, y)
        } else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-1, 0) * speed * Time.deltaTime);
        }
        

    }
}
