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
    [SerializeField] int RPS;
    [SerializeField] float spead;
    [SerializeField] GameObject muzzle;
    [SerializeField] bool haveSub;
    [SerializeField] int d1;
    [SerializeField] int d2;
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;
    [SerializeField] BulletStock_Script stock;
    int flameCount;
    float timecount;
    subShot_Script sub;
    // Start is called before the first frame update
    void Start()
    {
        AMMO = 100;
        source.mute=true;
        sub = GetComponent<subShot_Script>();
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
            timecount += Time.deltaTime;
            if (isLook)//�ǔ��̂ق�
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
        
        if (AMMO < 6)
        {
            if (!stock.canReload)
            {
                source.mute = true;return;
            }
            stock.reload();
            AMMO += 100;
        }
        //�����o����
        Debug.Log("muteon:"+(1.0f/RPS)+";"+timecount);
        source.mute = false;

        //if (flameCount % ((int)(1f / Time.deltaTime) / RPS) != 0) { return; }
        if (timecount<(1.0f/RPS)) { return; }
        Debug.Log("shot:"+timecount);
        shot(0);
        shot(d1);
        shot(d2);
        if (haveSub) { sub.subShot(1); }

        AMMO -= 6;
        timecount = 0;

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
            AMMO += 100;
        }
        source.mute = false;
        //if (flameCount % ((int)((1f / Time.deltaTime) / RPS)) != 0) { return; }
        if (timecount < (1.0f / RPS)) { return; }
        shot();
        AMMO--;
        timecount = 0;
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
            b.transform.rotation = Quaternion.FromToRotation(Vector3.up, diff);//�����Ő���
            //�����90�x���炵�Đ��ʂƂ������Ƃɂ���
            Quaternion q = Quaternion.AngleAxis(-90, new Vector3(0, 0, 1));
            b.transform.rotation = q * b.transform.rotation;
        }
        
        b.GetComponent<Rigidbody2D>().AddForce(ShotSimple_Script.GetDiff(b.transform.position, new Vector2(x, y)) * spead / 10);
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

        //�ȂȂ߂Ɍ�����
        Quaternion q = Quaternion.AngleAxis(deg, new Vector3(0, 0, 1));
        b.transform.rotation = q * b.transform.rotation;

        //�ȂȂ߂ɔ���
        float theta = deg * Mathf.Deg2Rad;
        Vector2 v = new Vector2(Mathf.Cos(theta), Mathf.Sin(theta));
        b.GetComponent<Rigidbody2D>().AddForce(v*spead/10);

    }
}
