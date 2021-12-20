using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public void SpawnPowerUP(Vector3 position, GameObject powerUp)
    {
        Instantiate(powerUp, position, Quaternion.identity );
    }
}
