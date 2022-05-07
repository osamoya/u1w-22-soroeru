using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 弾の管理をするスクリプト
/// 買った弾はここに行き、ここから各ボタンに入れる
/// 買えない、などの処理はこちらで行う
/// </summary>
public class BulletStock_Script : MonoBehaviour
{
    [SerializeField] int Stock;
    [SerializeField] int MAX;
    [SerializeField] List<GameObject> imgs=new List<GameObject>();
    
    public void OnClickBuy()
    {
        if (Stock < MAX)
        {
            //ここで買う指示
            return;
        }
        //限界値で買えない
        //ここに処理
    }
    private void Update()
    {
        //ここにStockによる描画
        //Stockの数字より大きいものの描画をしないようにする
        
        for (int i=0;i<MAX;i++)
        {
            if (i < Stock) imgs[i].SetActive(true);
            else imgs[i].SetActive(false);
        }
    }
}
