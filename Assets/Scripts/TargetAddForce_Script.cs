using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetAddForce_Script : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] int power;
    [SerializeField] float rad;
    [SerializeField] float rate;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.parent.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
         Debug.Log("‚Í‚¢‚Á‚½");
        float difx = transform.position.x - col.transform.position.x;
        if (difx > 0)
        {
            Debug.Log("a:dif=" + difx);
            difx = rate*difx - rad;
            Debug.Log("force=" + difx);
        }
        else
        {
            Debug.Log("b:dif=" + difx);
            difx = rate*difx + rad;
            Debug.Log("force=" + difx);
        }
        
        rb.AddForce(new Vector2(-difx,0)*power);
    }
}
