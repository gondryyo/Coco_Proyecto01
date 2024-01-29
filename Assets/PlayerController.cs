using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 UserInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.Translate(UserInput * Speed * Time.deltaTime);

    }

}


//https://medium.com/codex/its-alive-simple-2d-player-movement-in-unity-77e90c76cf28
