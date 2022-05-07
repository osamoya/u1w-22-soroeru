using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount_Script : MonoBehaviour
{
    [SerializeField] GameManager_Script GM;
    [SerializeField] SoundSE_Script se;
    float timeCount;
    bool isCounting;
    int dispM=0;
    int dispH=12;
    string s;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        isCounting = true;
        text = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            timeCount += Time.deltaTime*10;
            //timecountが1を超えた場合
            if (timeCount >= 1)
            {
                dispM++;
                timeCount -= 1;//Mを１にして、1引く

            }

            //Mが60になった瞬間に1足す
            if (dispM >= 60)
            {
                dispH++;
                dispM = 0;
            }
            if (dispH >= 13)//定時
            {
                //ここに何らかの処理
                Debug.Log("Time");
                GM.DoChange();
                isCounting = false;
                se.OnClickSE();
            }
            s = "" +dispH+":"+dispM.ToString("D2");
        }
        else
        {
            s = "CLOSE";
        }
        //文字列にする
        text.text = s;
    }
}
