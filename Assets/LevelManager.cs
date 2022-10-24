using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    private Transform ExplorerTransform;
    public Transform respawnPoint;
    public GameObject explorer;


    private void Start()
    {
        ExplorerTransform = GameObject.Find("Explorer").transform;
    }

    private void Awake() 
    {
        instance = this;
    }

   

    public void Respawn()
    {
        ExplorerTransform.position = respawnPoint.position;
    }


}
