using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TargetMove_Script : MonoBehaviour
{
    Vector2 move=new Vector2(0,0);
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        this.transform.DOMoveX(0f,2)
            .SetEase(Ease.InCubic)//Ease.InOutBounce)
            .SetLoops(10000,LoopType.Yoyo);
    }

    private void FixedUpdate()
    {
        //実行順がfixed→Ontiri→OnColiなので、
        //fixed最後で初期化して、最初に移動させる

        //移動させる
        rb.AddForce(move.normalized);

        //初期化
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //衝突した
        //衝突の処理
        //コイン
        //無敵時間
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        float x=collision.transform.position.x;
    }
}
