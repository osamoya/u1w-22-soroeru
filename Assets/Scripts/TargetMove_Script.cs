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
       
    }

    private void FixedUpdate()
    {
        //���s����fixed��Ontiri��OnColi�Ȃ̂ŁA
        //fixed�Ō�ŏ��������āA�ŏ��Ɉړ�������

        //�ړ�������
        rb.AddForce(move-new Vector2(transform.position.x,transform.position.y));

        //������
        move = new Vector2(0,0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�Փ˂���
        //�Փ˂̏���
        //�R�C��
        //���G����
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        float x=collision.transform.position.x;
    }
}
