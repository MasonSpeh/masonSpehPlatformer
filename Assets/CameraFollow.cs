using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    float position;


    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, -10);
    }

    

}
