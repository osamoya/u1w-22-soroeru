using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetAddForce_Script : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] int power;
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
        float diffx = transform.position.x - col.transform.position.x;
        rb.AddForce(new Vector2(diffx,0)*power);
    }
}
