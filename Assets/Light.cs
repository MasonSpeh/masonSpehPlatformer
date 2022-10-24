using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    
    private bool hide;
    public SpiderAI spiderAI;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find ("Darkness").transform.localScale = new Vector3(30, 30, 0);
        hide = false;
        spiderAI.LightOff();

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
                spiderAI.LitUp();
            }
            else
            {
                GameObject.Find("Darkness").transform.localScale = new Vector3(30, 30, 0);
                hide = false;
            }


        }
        if (Input.GetKeyDown("e"))
        {
            gameObject.SetActive(true);
            hide = false;
        }
    }
}
