using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private Transform ExplorerTransform;
    public Transform respawnPoint;
  

    private void Start()
    {
        ExplorerTransform = GameObject.Find("Explorer").transform;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ExplorerTransform.position = respawnPoint.position;

        }
    }
}
