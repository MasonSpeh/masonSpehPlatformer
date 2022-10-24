using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAI : MonoBehaviour
{
    
    public float speed2;
    public GameObject player;
    private bool isLitUp;
    private Rigidbody2D rb2;


    private float distance;


    // Start is called before the first frame update
    void Start()
    {
        isLitUp = true;
        rb2 = GetComponent<Rigidbody2D>();
        rb2.isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isLitUp == false)
        {
            rb2.isKinematic = true;
            
        }
        else
        {
            
            rb2.isKinematic = false;
            distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 direction = player.transform.position - transform.position;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


            if (distance < 16)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed2 * Time.deltaTime);
                transform.rotation = Quaternion.Euler(Vector3.forward * angle);
            }
        }
        
      
    }

    public void LitUp()
    {
        isLitUp = true;
    }

    public void LightOff()
    {
        isLitUp = false;
    }




}
