using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    //patrón de diseño, hay una clase que solo puede existir 1 en todo el proyecto, solo puede existir una copia de esa clase.
    private void Move()
    {
        Vector3 direction = (Player.Instance.transform.position - transform.position).normalize;

        rb.AddForce(direction * speed);
    }

    private void FixedUpdate()
    {
        Move();
    }
}

