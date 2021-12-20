using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         Destroy(gameObject, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,  0, -45);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PowerUpSpawner>() != null ) //box 
        {
            GetComponent<CircleCollider2D>().enabled = false;
            collision.gameObject.GetComponent<PowerUpSpawner>().SpawnPowerUp();
        }
        else if (collision.gameObject.GetComponent<Bomb>() != null) //bomb 
        {
            collision.gameObject.GetComponent<Bomb>().Explode();
        }else if (collision.gameObject.GetComponent<Fire>() != null) //fire
        {
            return;
        }

        Destroy(collision.gameObject);
    }
}
