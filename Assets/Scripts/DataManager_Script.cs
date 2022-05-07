using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager_Script : MonoBehaviour
{
    [SerializeField] public int b1;//値段
    [SerializeField] ShotOnOff_Script shot1;

    [SerializeField] public int b2;//値段
    [SerializeField] ShotOnOff_Script shot2;
    
    [SerializeField] public static int coin { get; private set; }
    [SerializeField] int startCoin;
    private void Start()
    {
        coin = startCoin;
    }
    public void BuyAMMO(int n)
    {
        Debug.Log("買います");
        int price=999;
        switch (n)
        {
            case 1:price = b1;; break;
            case 2:price = b2;; break;
            default:return;
        }

        

        coin -= price;
        
        Debug.Log("残り："+coin);



    }
}
