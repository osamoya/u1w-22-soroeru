using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotOnOff_Script : MonoBehaviour
{
    public int AMMO {get;set;}
    public bool Shooting { get; private set; }
    public GameObject bullet;
    [SerializeField] bool isRotate;
    [SerializeField] bool isLook;
    [SerializeField] GameObject muzzle;
    [SerializeField] GameObject muzzle2;
    [SerializeField] int d1;
    [SerializeField] int d2;
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;
    [SerializeField] BulletStock_Script stock;
    int flameCount;
    // Start is called before the first frame update
    void Start()
    {
        AMMO = 500;
        source.mute=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager_Script.NowState != GameManager_Script.state.Shooting) {
            Shooting = false;
            source.mute = true;
            return;
        }
        
        if (Shooting)
        {
            flameCount++;

            if (isLook)//追尾のほう
            {
                shot4u();
                return;
            }
            else
            {
                Shot3way();
                return;
            }
            
            
        }
        else
        {
            source.mute = true;
        }
        
    }


    void Shot3way()
    {
        
        if (AMMO < 3)
        {
            if (!stock.canReload)
            {
                source.mute = true;return;
            }
            stock.reload();
            AMMO += 1000;
        }
        //音を出して
        source.mute = false;

        if (flameCount % 20 != 0) { return; }
        shot(0);
        shot(d1);
        shot(d2);
        AMMO -= 3;
        

    }
    void shot4u()
    {

        if (AMMO < 1)
        {
            if (!stock.canReload)
            {
                source.mute = true; return;
            }
            stock.reload();
            AMMO += 1000;
        }
        source.mute = false;
        if (flameCount % 20 != 0) { return; }
        shot();
        AMMO--;
        
    }


    void shot()
    {
        shot(ShotManager_Script.targetPos);
    }


    public void onClickButton()
    {
        if (GameManager_Script.NowState != GameManager_Script.state.Shooting) { return; }
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
        Debug.Log("1つめ終了");
        if (!isLook)
        {
            Debug.Log("ここまで来てます");
            GameObject b2 = Instantiate(bullet);
            b2.transform.position = muzzle2.transform.position;
            diff = b2.transform.position - new Vector3(x, y, 0);

            if (isRotate)
            {
                b2.transform.rotation = Quaternion.FromToRotation(Vector3.up, diff);//ここで正面
                                                                                   //さらに90度ずらして正面ということにする
                Quaternion q = Quaternion.AngleAxis(-90, new Vector3(0, 0, 1));
                b2.transform.rotation = q * b2.transform.rotation;
            }

            b2.GetComponent<Rigidbody2D>().AddForce(ShotSimple_Script.GetDiff(b2.transform.position, new Vector2(x, y)));
        }
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
