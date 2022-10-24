using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesHealth : MonoBehaviour
{
    public int ehealth = 8;
    public int emaxHealth = 8;


    private Transform ExplorerTransform;



    // Start is called before the first frame update
    void Start()
    {
        ehealth = emaxHealth;
     
   
    }

 

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Rock")
        {
            ehealth -= 4;

            if (ehealth <= 0)
            {
                Destroy(gameObject);
            }


        }

    }
}