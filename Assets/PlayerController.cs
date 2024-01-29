using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    //definir variables c:

    public static PlayerController Instance;

    [SerializeField] private float speed;
    [SerializeField] private GameObject bulletPrefab;

    private PlayerInputAct playerInputActions;
    private Rigidbody2D rb;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        playerInputActions = new PlayerInputAct();
        rb = GetComponent<Rigidbody2D>();
    }

    //llamar la clase y "validar" la variable
    void Start()
    {
        playerInputActions.Enable();
        playerInputActions.PlayerInputs.Shooting.performed += Shoot;
    }

    //el player se moverá en dirección que se aplique el input, puede ser Vector2 o Vector3.
    private void Move()
    {
        Vector3 direction = new Vector3(playerInputActions.PlayerInputs.Movement.ReadValue<Vector2>().x, playerInputActions.PlayerInputs.Movement.ReadValue<Vector2>().y, 0); //se agregaba "normalized" al final para solucionar que al moverse en diagonal no se mueva más rápido y así.
        rb.AddForce(direction * speed);
    }
     //siempre que se usa RB, los cálculos tienen que pasar en el FixedUpdate, para que no sea tan pesado. Ya que Update son cada frame.
     //Así se baja lo pesado que es hacer el cálculo de la física.
    private void FixedUpdate()
    {
        Move();

    }
    //quaternion son un tipo de rotaciones, al imaginar que un objeto rota es mejor con palitos, por eso se agregan los ángulos.
    private void Shoot(InputAction.CallbackContext context)
    {
        string buttonName = context.control.name;

        switch (buttonName)
        {
            case "upArrow":
                Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, 90));
                break;

            case "downArrow":
                Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, -90));
                break;

            case "leftArrow":
                Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, 180));
                break;

            case "rightArrow":
                Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                break;
        }

    }


    void Update()
    {
       
    }

   
}


