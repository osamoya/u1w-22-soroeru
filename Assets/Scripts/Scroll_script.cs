using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_script : MonoBehaviour
{
    Vector3 speed = new Vector3(0, 0.2f, 0);
    Vector3 x = new Vector3(0, -10.75f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed;
        if(transform.position.y>= 10.75)
        {
            transform.localPosition=x;
        }
    }
}
