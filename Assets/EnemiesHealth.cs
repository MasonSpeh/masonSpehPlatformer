using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesHealth : MonoBehaviour
{
    public int ehealth = 8;
    public int emaxHealth = 8;
    public int dmgIncrease;
    public int totalDMG = 4;


    private Transform ExplorerTransform;



    // Start is called before the first frame update
    void Start()
    {
        ehealth = emaxHealth;
        dmgIncrease = 0;
        totalDMG = 4;
   
    }

    private void Update()
    {
        totalDMG = 4 + dmgIncrease;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Rock")
        {
            ehealth -= totalDMG;

            if (ehealth <= 0)
            {
                Destroy(gameObject);
            }
            

        }
        


        if (collision.gameObject.tag == "Sword")
        {
            dmgIncrease = dmgIncrease + 2;

            
        }


    }
    

    public void AddDMG()
    {
        dmgIncrease = dmgIncrease + 2;
    }



}