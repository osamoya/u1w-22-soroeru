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
    }
}
