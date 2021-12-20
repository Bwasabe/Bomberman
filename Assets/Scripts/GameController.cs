using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public const int X = 22;
    public const int Y = 13;

    public GameObject levelHolder;
    public GameObject[,] level = new GameObject[X, Y]; //grid


    // Start is called before the first frame update
    void Start()
    {
        var levels = levelHolder.GetComponentsInChildren<Transform>();
        foreach(var child in levels)
        {
            level[(int)child.position.x,(int)child.position.y] = child.gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
