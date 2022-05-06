using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotOnOff_Script : MonoBehaviour
{
    public int AMMO {get;set;}
    public bool Shooting { get; private set; }
    public GameObject bullet;
    [SerializeField] bool isRotate;
    [SerializeField] GameObject muzzle;
    [SerializeField] int d1;
    [SerializeField] int d2;
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        AMMO = 50000;
        source.mute=true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Shooting)
        {
            if (AMMO < 3) { source.mute = true; return; }
            shot(0);
            shot(d1);
            shot(d2);
            AMMO -= 3;
            Debug.Log("鳴らします");
            source.mute = false;
        }
        else
        {
            source.mute = true;
        }
        
    }

    void shot()
    {
        shot(ShotManager_Script.targetPos);
    }


    public void onClickButton()
    {
        Shooting = !Shooting;
    }

    public void shot(float x, float y)
    {
        GameObject b=Instantiate(bullet);
        b.transform.position = muzzle.transform.position;
        Vector3 diff = b.transform.position - new Vector3(x, y, 0);
        
        if (isRotate)
        {
            b.transform.rotation = Quaternion.FromToRotation(Vector3.up, diff);//ここで正面
            //さらに90度ずらして正面ということにする
            Quaternion q = Quaternion.AngleAxis(-90, new Vector3(0, 0, 1));
            b.transform.rotation = q * b.transform.rotation;
        }
        
        b.GetComponent<Rigidbody2D>().AddForce(ShotSimple_Script.GetDiff(b.transform.position, new Vector2(x, y)));
    }

    public void shot(Vector2 v)
    {
        shot(v.x, v.y);
    }
    public void shot(int deg)
    {
        deg += 90;
        GameObject b = Instantiate(bullet);
        b.transform.position = muzzle.transform.position;

        //ななめに向けて
        Quaternion q = Quaternion.AngleAxis(deg, new Vector3(0, 0, 1));
        b.transform.rotation = q * b.transform.rotation;

        //ななめに発射
        float theta = deg * Mathf.Deg2Rad;
        Vector2 v = new Vector2(Mathf.Cos(theta), Mathf.Sin(theta));
        b.GetComponent<Rigidbody2D>().AddForce(v);

    }
}
