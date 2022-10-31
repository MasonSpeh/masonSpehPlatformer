using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraDMG : MonoBehaviour
{
    public EnemiesHealth enemyhealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            enemyhealth.AddDMG();

            Destroy(gameObject);
        }

    }
}
