using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    public int checkpointnum;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-40, 20, 0);
        checkpointnum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Checkpoint1()
    {
        if (checkpointnum == 0)
        {
            transform.position = new Vector3(53, 20, 0);
            checkpointnum = checkpointnum + 1;
        }
        else
        {
            transform.position = new Vector3(100, -73, 0);
            checkpointnum = checkpointnum + 1;
        }
        
    }
}
