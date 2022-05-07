using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispAMMO_Script : MonoBehaviour
{
    DataManager_Script dataManager_;
    [SerializeField] int bullet_num;
    [SerializeField] BulletStock_Script stock;
    int price;
    bool canBuy;
    // Start is called before the first frame update
    void Start()
    {
        dataManager_ = GameObject.Find("TestManager").GetComponent<DataManager_Script>();
        switch (bullet_num)//値段の設定
        {
            case 1:price = dataManager_.b1;break;
            case 2:price = dataManager_.b2;break;
            default:return;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (DataManager_Script.coin<price)
        {
            canBuy = false;
        }
        else
        {
            canBuy = true;
        }
    }

    public void OnClickBuy()
    {
        Debug.Log("押された。買おうとしている");
        if (!canBuy)
        {
            //それ用の処理
            //色を変えたり表示したり
            return;
        }
        //MAXの確認
        if (stock.isMax)
        {
            //それ用の処理
            return;
        }

        //買う処理
        //dataManager_.BuyAMMO(bullet_num);
        stock.OnClickBuy();
    }
}
