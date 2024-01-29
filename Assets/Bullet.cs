using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
      public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.UpArrow)) 
       {
            var Bullet = Instantiate(bulletPrefab,transform.position, transform.rotation) as GameObject;

            Bullet.transform.Translate(Vector2.right * 20f * Time.deltaTime);
       }

       if(Input.GetKey(KeyCode.DownArrow)) 
       {
            var Bullet = Instantiate(bulletPrefab,transform.position, transform.rotation) as GameObject;

            Bullet.transform.Translate(Vector2.right * 20f * Time.deltaTime);
       }

       if(Input.GetKey(KeyCode.LeftArrow)) 
       {
            var Bullet = Instantiate(bulletPrefab,transform.position, transform.rotation) as GameObject;

            Bullet.transform.Translate(Vector2.right * 20f * Time.deltaTime);
       }

       if(Input.GetKey(KeyCode.RightArrow)) 
       {
            var Bullet = Instantiate(bulletPrefab,transform.position, transform.rotation) as GameObject;

            Bullet.transform.Translate(Vector2.right * 20f * Time.deltaTime);
       }
    }
}

//https://discussions.unity.com/t/how-do-i-shoot-an-arrow-in-the-direction-of-the-player-when-i-press-the-spacebar-key-for-a-2d-top-down-game/256850