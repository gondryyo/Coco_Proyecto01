using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float pushForce;
    [SerializeField] private int maxHP;

    private Rigidbody2D rb;
    private int hp;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hp = maxHP;
    }


    //patrón de diseño, hay una clase que solo puede existir 1 en todo el proyecto, solo puede existir una copia de esa clase.
    private void Move()
    {
        Vector3 direction = (PlayerController.Instance.transform.position - transform.position).normalized;

        rb.AddForce(direction * speed);
    }

    public void Hit(int damage)
    {
        hp -= damage;
            if (hp <= 0)
        {

        }
    }

    public void Push()
    {

    }

    private void FixedUpdate()
    {
        Move();
    }
}

