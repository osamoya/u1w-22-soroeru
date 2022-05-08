using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subShot_Script : MonoBehaviour
{
    [SerializeField] GameObject subMuzzle;
    [SerializeField] GameObject bullet;
    [SerializeField] float spead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void subShot(int n)
    {
        switch (n)
        {
            case 1:
                shot(0);
                shot(15);
                shot(-15);
                break;
            case 2:
                break;
        }
        
    }

    public void shot(int deg)
    {
        deg += 90;
        GameObject b = Instantiate(bullet);
        b.transform.position = subMuzzle.transform.position;

        //‚È‚È‚ß‚ÉŒü‚¯‚Ä
        Quaternion q = Quaternion.AngleAxis(deg, new Vector3(0, 0, 1));
        b.transform.rotation = q * b.transform.rotation;

        //‚È‚È‚ß‚É”­ŽË
        float theta = deg * Mathf.Deg2Rad;
        Vector2 v = new Vector2(Mathf.Cos(theta), Mathf.Sin(theta));
        b.GetComponent<Rigidbody2D>().AddForce(v * spead / 10);

    }
}
