using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bomb;

    public int numberOfBombs = 2;
    public int firePower = 1;
    public float fuse = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && numberOfBombs >= 1)
        {
            Vector2 spawnPos = new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y));
            var newBomb = Instantiate(bomb,spawnPos, Quaternion.identity);
            newBomb.GetComponent<Bomb>().firePower = firePower;
            newBomb.GetComponent<Bomb>().fuse = fuse;
            numberOfBombs--;
            Invoke("AddBomb", 1);
        }
    }

    public void AddBomb()
    {
        numberOfBombs++;
    }
}
