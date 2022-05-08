using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TargetMove_Script : MonoBehaviour
{
    Vector2 move=new Vector2(0,0);
    Vector2 center = new Vector2(-4.5f, 3);
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    private void FixedUpdate()
    {
        //実行順がfixed→Ontiri→OnColiなので、
        //fixed最後で初期化して、最初に移動させる

        //移動させる
        rb.AddForce(center-new Vector2(transform.position.x,transform.position.y));

        //初期化
        move = new Vector2(0,0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //衝突した
        //衝突の処理
        //コイン
        
        //無敵時間
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
