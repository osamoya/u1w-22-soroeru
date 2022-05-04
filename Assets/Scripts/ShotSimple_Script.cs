using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSimple_Script : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullet2;

    public void shot()//使わない
    {
        shot(1,ShotManager_Script.targetPos);
    }
    public void shot(int n,float x,float y)
    {
        GameObject b;
        switch (n)
        {
            case 1: b = Instantiate(bullet); break;
            case 2: b = Instantiate(bullet2); break;
            default:b = Instantiate(bullet); break;
        }
        b.transform.position = this.transform.position;
        b.GetComponent<Rigidbody2D>().AddForce(GetDiff(b.transform.position,new Vector2(x,y)));
    }
    public void shot(int n, Vector2 v)
    {
        shot(n,v.x,v.y);
    }
    public  void shot(int num)//番号指定
    {
        switch (num)
        {
            case 1:
            case 2:
                shot(num,ShotManager_Script.targetPos);
                break;
            default:
                Debug.Log("No item");
                break;
        }
    }
    

    Vector2 GetDiff(Vector2 start,Vector2 goal)
    {
        return (goal - start).normalized;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //shot(ShotManager_Script.targetPos);
            //Debug.Log(ShotManager_Script.targetPos);
        }
    }

}
