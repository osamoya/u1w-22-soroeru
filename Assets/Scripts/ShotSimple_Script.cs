using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSimple_Script : MonoBehaviour
{
    public GameObject bullet;

    public void shot()
    {
        shot(0,0);
    }
    public void shot(float x,float y)
    {
        GameObject b = Instantiate(bullet);
        b.transform.position = new Vector2(0, -1);
        b.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1));
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            shot();
        }
    }

}
