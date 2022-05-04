using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSimple_Script : MonoBehaviour
{
    public GameObject bullet;

    public void shot()
    {
        shot(ShotManager_Script.targetPos);
    }
    public void shot(float x,float y)
    {
        GameObject b = Instantiate(bullet);
        b.transform.position = this.transform.position;
        b.GetComponent<Rigidbody2D>().AddForce(GetDiff(b.transform.position,new Vector2(x,y)));
    }
    public void shot(Vector2 v)
    {
        shot(v.x,v.y);
    }

    Vector2 GetDiff(Vector2 start,Vector2 goal)
    {
        return (goal - start).normalized;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            shot(ShotManager_Script.targetPos);
            Debug.Log(ShotManager_Script.targetPos);
        }
    }

}
