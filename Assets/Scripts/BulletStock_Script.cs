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
    DataManager_Script dataManager_;
    [SerializeField] int Stock;
    [SerializeField] int MAX;
    public bool isMax { get; private set; }
    public bool canReload { get; private set; }
    [SerializeField] List<GameObject> imgs=new List<GameObject>();
    
    public void OnClickBuy(int n)
    {
        //変更：こいつは確定で買えるときに呼ばれる
        Stock++;
        //ここに、金額の話
        dataManager_.BuyAMMO(n);
    }
    private void Start()
    {
        dataManager_ = GameObject.Find("TestManager").GetComponent<DataManager_Script>();

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
        if (Stock > 0) { canReload = true; }
    }
    public void reload()
    {
        Stock--;
        if (Stock <= 0) { canReload = false; }
    }
}
