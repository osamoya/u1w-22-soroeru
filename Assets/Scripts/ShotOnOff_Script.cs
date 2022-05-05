using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotOnOff_Script : MonoBehaviour
{
    public bool Shooting { get; private set; }
    public GameObject bullet;
    [SerializeField] bool isRotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Shooting)
        {
            shot(ShotManager_Script.targetPos) ;
        }
    }

    public void onClickButton()
    {
        Shooting = !Shooting;
    }

    public void shot(float x, float y)
    {
        GameObject b=Instantiate(bullet);
        b.transform.position = this.transform.position;
        Vector3 diff = b.transform.position - new Vector3(x, y, 0);
        
        if (isRotate)
        {
            b.transform.rotation = Quaternion.FromToRotation(Vector3.up, diff);//Ç±Ç±Ç≈ê≥ñ 
            //Ç≥ÇÁÇ…90ìxÇ∏ÇÁÇµÇƒê≥ñ Ç∆Ç¢Ç§Ç±Ç∆Ç…Ç∑ÇÈ
            Quaternion q = Quaternion.AngleAxis(-90, new Vector3(0, 0, 1));
            b.transform.rotation = q * b.transform.rotation;
        }
        
        b.GetComponent<Rigidbody2D>().AddForce(ShotSimple_Script.GetDiff(b.transform.position, new Vector2(x, y)));
    }

    public void shot(Vector2 v)
    {
        shot(v.x, v.y);
    }

}
