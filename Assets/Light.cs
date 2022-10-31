using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    
    private bool hide;
    public SpiderAI[] spiderAI;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find ("Darkness").transform.localScale = new Vector3(30, 30, 0);
        hide = false;

        spiderAI = GameObject.FindObjectsOfType<SpiderAI>();

        for(int i=0;i<spiderAI.Length;i++)
        {
            spiderAI[i].LightOff();
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            if (hide == false)
            {
                GameObject.Find("Darkness").transform.localScale = new Vector3(0, 0, 0);
                hide = true;
                
                for(int i = 0; i < spiderAI.Length; i++)
                { 
                    spiderAI[i].LitUp();
                }
            }
            else
            {
                GameObject.Find("Darkness").transform.localScale = new Vector3(30, 30, 0);
                hide = false;
                for (int i = 0; i < spiderAI.Length; i++)
                {
                    spiderAI[i].LightOff();
                }

            }


        }
        
    }
}
