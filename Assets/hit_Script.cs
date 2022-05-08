using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class hit_Script : MonoBehaviour
{
    [SerializeField] Vector2 sPos;
    bool isSafeTime;
    GameObject fly;
    float count = 0;
    SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        isSafeTime = false;
        fly = transform.parent.gameObject;
        renderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isSafeTime)
        {
            count += Time.deltaTime;
            if (count >= 4f)//2ïbÇΩÇ¡ÇΩÇÁñ≥ìGâèú
            {
                Debug.Log("âèú");
                isSafeTime = false;
                count = 0;
            }
            

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isSafeTime) { return; }
        if (collision.tag != "Bullet") { return; }
            Debug.Log("bb");
        isSafeTime = true;

        Sequence sequence = DOTween.Sequence();
        sequence.Append(renderer.DOFade(0, .3f).SetLoops(10, LoopType.Yoyo));
        sequence.Join(fly.transform.DOMove(sPos, 2f));
        sequence.Append(renderer.DOFade(1, 0));
        sequence.Play();
        DataManager_Script.PaidCoin();
        
    }
}
