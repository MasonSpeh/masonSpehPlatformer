using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explorer : MonoBehaviour
{
    private Rigidbody2D rb;
    private int jumps;
    private bool grounded;
    public int maxJumps = 2;
    public Vector3 position;
    public Rock RockPrefab;
    public Transform DirectionShoot;
    public bool FacingRight;
    
    public int hamt = 5;
    public int maxRocks = 4;
    private int currentRocks;

    
  
   


    // Start is called before the first frame update
    private void Start()
    {
        currentRocks = 4;
        rb = GetComponent<Rigidbody2D>();
        
        
    }

    


    // Update is called once per frame
    private void Update()
    {
        

        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 8f, rb.velocity.y);

        
       
        if (Input.GetKeyDown("a"))
        {
            
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKeyDown("d"))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }



        if (Input.GetButtonDown("Jump"))
        {
            if (jumps > 0)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(rb.velocity.x, 14f), ForceMode2D.Impulse);
                grounded = false;
                jumps = jumps - 1;

            }
            if (jumps == 0)
            {
                return;
            }
        }

        

        if (Input.GetButtonDown("Fire1"))
        {
            if (currentRocks >= 1)
            {
                Instantiate(RockPrefab, DirectionShoot.position, transform.rotation);
                currentRocks = currentRocks - 1;
            }
            

        }

        if (Input.GetKeyDown("s"))
            if (currentRocks <= maxRocks)
            {
                currentRocks = currentRocks + 1;
            }



    }

    
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Platform")
        {
            jumps = maxJumps;
            grounded = true;
            
        }
        

    }

    


}
