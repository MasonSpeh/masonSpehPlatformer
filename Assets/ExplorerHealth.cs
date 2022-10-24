using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExplorerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
    public TextMeshProUGUI hp;
    

    private Transform ExplorerTransform;



    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        ExplorerTransform = GameObject.Find("Explorer").transform;
        hp.text = health.ToString();
    }

    // Update is called once per frame
    public void TakeDamage (int amount)
    {
        health -= amount;
        hp.text = health.ToString();
        if (health <= 0)
        {
            ExplorerTransform.position = LevelManager.instance.respawnPoint.position;
            health = maxHealth;
            hp.text = health.ToString();
        }
    }
}
